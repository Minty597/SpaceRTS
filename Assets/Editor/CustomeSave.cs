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
                        Debug.Log("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        

                        try
                        {
                            Debug.Log(">>" + Field.PropertyType.ToString());
                            Text.Append(Field.PropertyType.ToString() + Environment.NewLine);
                            Debug.Log(">>" + Field.Name.ToString());
                            Text.Append(Field.Name.ToString() + Environment.NewLine);
                            Debug.Log(">>" + Field.GetValue(GO, null));
                            Text.Append(Field.GetValue(GO, null) + Environment.NewLine);
                        }
                        catch (System.NotSupportedException e)
                        {
                            Debug.Log("Ignoreing property: " + Field.Name.ToString());
                            Text.Append("Ignoreing property: " + Field.Name.ToString() + Environment.NewLine);
                        }
                    }
                    Debug.Log("Components");
                    foreach (Component CompInGO in GO.GetComponents(typeof(Component)))
                    {
                        Debug.Log("//////////////////////////////////");
                        Debug.Log("Component: " + CompInGO.name);
                        foreach (System.Reflection.PropertyInfo CompententFields in CompInGO.GetType().GetProperties())
                        {
                            Debug.Log("#############################################");

                            try
                            {
                                Debug.Log("++++" + CompententFields.PropertyType.ToString());
                                Text.Append(CompententFields.PropertyType.ToString() + Environment.NewLine);
                                Debug.Log("++++" + CompententFields.Name.ToString());
                                Text.Append(CompententFields.Name.ToString() + Environment.NewLine);
                                Debug.Log("++++" + CompententFields.GetValue(CompInGO, null));
                                Text.Append(CompententFields.GetValue(CompInGO, null)+Environment.NewLine);
                            }
                            catch (System.NotSupportedException e)
                            {
                                Debug.Log("Ignoreing Component property: " + CompententFields.Name.ToString());
                            }

                        }
                    }
                    Debug.Log(Text);
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

