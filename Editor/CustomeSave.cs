using UnityEngine;
using UnityEditor;
using System;
using System.Collections;
using System.Text;


public class CustomeSave : EditorWindow
{
    private string Scale = "scale Value";




    [MenuItem("Custom Tools/Custom Save")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(CustomeSave));
    }


    void OnGUI()
    {
        Scale = GUILayout.TextField(Scale);

        if(GUILayout.Button("Save"))
        {
            float fScale=0;
            if(float.TryParse(Scale, out fScale))
            {
                //loop through all objects in scene
                GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();

                StringBuilder Text = new StringBuilder();
                foreach(GameObject GO in allObjects)
                {
                    //System.Xml.Serialization.XmlSerializer write = new
                    //System.Xml.Serialization.XmlSerializer(typeof(GameObject));
                    

                    //System.Xml.XmlWriter STFU = System.Xml.XmlWriter.Create(Text);

                    //write.Serialize(STFU, GO);

                    //System.Reflection.MemberInfo info = typeof(GameObject).GetMethods();
                    //object[] attributes = info.GetCustomAttributes(true);
                    

                    GO.GetType();
                    foreach (System.Reflection.PropertyInfo Field in GO.GetType().GetProperties())
                    {
                        Debug.Log(">>"+Field.Name.ToString());
                        Debug.Log(">>" + Field.GetValue(GO,null));

                        //foreach (Attribute a in Field.GetCustomAttributes(true))
                        //{
                        //    Debug.Log(">>>" + a.ToString());
                        //}
                    }
                    break;

                }

                
                

                //Debug.Log(Text);


            }
            else
            {
                //catch error
                Debug.Log("Scale  is not NaN!");
            }

            
        }

    }
}

