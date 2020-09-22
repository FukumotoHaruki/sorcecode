using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TodoApp;

public class MainForm : MonoBehaviour
{

    private readonly TaskApp app = new TaskApp();

    public InputField inputFieldName;

    public LayoutGroup container;

    public GameObject itemTemplate;

    GameObject ExpImage;

    public void Start()
    {
        app.Load();
        foreach (var task in app.Tasks)
        {
            this.CreateTaskUI(task);
        }

        ExpImage = GameObject.Find("Canvas/ExpImage");

        ExpImage.SetActive(false);
    }

    public void AddTaskClick()
    {
        if (string.IsNullOrEmpty(this.inputFieldName.text))
        {
            return;
        }

        var task = AddTask();
        this.CreateTaskUI(task);
        app.Save();
    }

    private Task AddTask()
    {
        var task = new Task
        {
            Name = this.inputFieldName.text
            
        };
        app.Tasks.Add(task);

        this.inputFieldName.text = string.Empty;
        return task;
    }

    private void CreateTaskUI(Task task)
    {
        var item = (GameObject)Instantiate(this.itemTemplate);
        var toggle = item.GetComponentInChildren<Toggle>();
        toggle.isOn = task.Done;
        var text = item.GetComponentInChildren<Text>();
        text.text = task.Name;
        //ここで子オブジェクトのテキストについて変更
        text.fontSize = 40;
        item.transform.SetParent(this.container.transform);

        item.SendMessage("SetApp", app);
        item.SendMessage("SetTargetTask", task);
        
    }
}
