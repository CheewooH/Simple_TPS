using System.Collections;
using System.Collections.Generic;
using CustomUtility.IO;
using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] CsvTable _monsterCSV;

    private void Awake() =>Init();
    
    private void Start() => TestMethod();
    private void Init()
    {

    }
    private void TestMethod ()
    {

    }
}
