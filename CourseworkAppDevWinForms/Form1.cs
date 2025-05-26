using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Coursework_AppDev;
using Python.Runtime;
using Tesseract;

namespace CourseworkAppDevWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_Encode_Click(object sender, EventArgs e)
        {
            try
            {
                StringProcessing stringProcessing = new StringProcessing(tb_InputString.Text, Convert.ToInt16(tb_InputInt.Text));
                stringProcessing.Encode();
                lb_Result.Text = "Result: " + stringProcessing.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_InputCode_Click(object sender, EventArgs e)
        {
            try
            {
                StringProcessing stringProcessing = new StringProcessing(tb_InputString.Text, Convert.ToInt16(tb_InputInt.Text));
                lb_Result.Text = "Result: " + stringProcessing.InputCode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_OutputCode_Click(object sender, EventArgs e)
        {
            try
            {
                StringProcessing stringProcessing = new StringProcessing(tb_InputString.Text, Convert.ToInt16(tb_InputInt.Text));
                stringProcessing.Encode();
                lb_Result.Text = "Result: " + stringProcessing.OutputCode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_Sort_Click(object sender, EventArgs e)
        {
            try
            {
                StringProcessing stringProcessing = new StringProcessing(tb_InputString.Text, Convert.ToInt16(tb_InputInt.Text));
                lb_Result.Text = "Result: " + stringProcessing.Sort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pb_GreenwichLogo_Click(object sender, EventArgs e)
        {

        }

        private void bt_Encode_MouseHover(object sender, EventArgs e)
        {
            lb_NoteButton.Text = "Note: Convert string to string";
        }

        private void bt_Encode_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_InputCode_MouseHover(object sender, EventArgs e)
        {
            lb_NoteButton.Text = "Note: Convert string to number";
        }

        private void bt_OutputCode_MouseHover(object sender, EventArgs e)
        {
            lb_NoteButton.Text = "Note: Convert encoded string to number";
        }

        private void bt_Sort_MouseHover(object sender, EventArgs e)
        {
            lb_NoteButton.Text = "Note: Sort the string";
        }

        private void bt_Encode_MouseLeave(object sender, EventArgs e)
        {
            lb_NoteButton.Text = "Note:";
        }

        private void bt_InputCode_MouseLeave(object sender, EventArgs e)
        {
            lb_NoteButton.Text = "Note:";
        }

        private void bt_OutputCode_MouseLeave(object sender, EventArgs e)
        {
            lb_NoteButton.Text = "Note:";
        }

        private void bt_Sort_MouseLeave(object sender, EventArgs e)
        {
            lb_NoteButton.Text = "Note:";
        }
        private string GetPythonDllPath()
        {
            StreamReader MyFile = new StreamReader("python.txt");
            return MyFile.ReadLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Runtime.PythonDLL = GetPythonDllPath();
            PythonEngine.Initialize();
            try
            {
                string debugPath = "mediapipe_image.jpg";
                string pythonCode = $@"
import cv2
import mediapipe as mp
import math
import numpy as np
from ocr_tamil.ocr import OCR

mp_hands = mp.solutions.hands
mp_drawing = mp.solutions.drawing_utils

def calculate_distance(p1, p2):
    return math.sqrt((p1.x - p2.x) ** 2 + (p1.y - p2.y) ** 2)

def get_text_from_image():
    cap = cv2.VideoCapture(0)
    tracing_points = []

    with mp_hands.Hands(min_detection_confidence=0.2, min_tracking_confidence=0.2) as hands:
        while cap.isOpened():
            ret, frame = cap.read()
            if not ret:
                break
            frame = cv2.flip(frame, 1)

            rgb_frame = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)

            results = hands.process(rgb_frame)

            if results.multi_hand_landmarks:
                for landmarks in results.multi_hand_landmarks:
                    mp_drawing.draw_landmarks(frame, landmarks, mp_hands.HAND_CONNECTIONS)

                    if calculate_distance(landmarks.landmark[8], landmarks.landmark[4]) > 0.1:
                        index_tip = landmarks.landmark[8]
                        index_tip_position = (int(index_tip.x * frame.shape[1]), int(index_tip.y * frame.shape[0]))
                        tracing_points.append(index_tip_position)
                        cv2.circle(frame, index_tip_position, 5, (0, 255, 0), -1)

                    if calculate_distance(landmarks.landmark[8], landmarks.landmark[4]) < 0.1:
                        index_tip = landmarks.landmark[8]
                        index_tip_position = (int(index_tip.x * frame.shape[1]), int(index_tip.y * frame.shape[0]))
                        tracing_points.append(None)
                        cv2.circle(frame, index_tip_position, 5, (255, 0, 0), -1)

                    if len(tracing_points) > 1:
                        for i in range(1, len(tracing_points) - 1):
                            if tracing_points[i - 1] != None and tracing_points[i] != None:
                                cv2.line(frame, tracing_points[i - 1], tracing_points[i], (0, 0, 255), 2)
                            else:
                                continue

                    if landmarks.landmark[4].y < landmarks.landmark[3].y < landmarks.landmark[2].y and landmarks.landmark[12].y < landmarks.landmark[11].y < landmarks.landmark[10].y and landmarks.landmark[16].y < landmarks.landmark[15].y < landmarks.landmark[14].y and landmarks.landmark[20].y < landmarks.landmark[19].y < landmarks.landmark[18].y:
                        white_image = np.ones((frame.shape[0], frame.shape[1], 3), dtype=np.uint8) * 255
                        if len(tracing_points) > 1:
                            for i in range(1, len(tracing_points) - 1):
                                if tracing_points[i - 1] != None and tracing_points[i] != None:
                                    cv2.line(white_image, tracing_points[i - 1], tracing_points[i], (0, 0, 0), 2)
                                else:
                                    continue
                        
                        # Sử dụng đường dẫn thư mục Debug
                        image_path = r'{debugPath}'
                        cv2.imwrite(image_path, white_image)
                        ocr = OCR()
                        text_list = ocr.predict(image_path)
                        cap.release()
                        cv2.destroyAllWindows()
                        return text_list[0] if text_list[0] != '' else ""Text is not recognized""

            cv2.imshow('Hand Landmarks', frame)

            if cv2.waitKey(1) & 0xFF == ord('q'):
                break

    cap.release()
    cv2.destroyAllWindows()
    return 'No text detected'";

                using (Py.GIL())
                {
                    using (PyModule scope = Py.CreateScope())
                    {
                        scope.Exec(pythonCode);
                        dynamic getTextFunction = scope.Get("get_text_from_image");
                        string result = getTextFunction().ToString();
                        tb_InputString.Text = result.ToUpper().Replace(" ", "");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                PythonEngine.Shutdown();
            }
        }
    }
}