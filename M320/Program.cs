/*
Wie können Felder von Eigenschaften unterschieden werden? Oder angers gefragt: Woran ist bei einer Instanzvariable in C# erkennbar, ob es ein Feld oder eine Eigenschaft ist?
Worin unterscheidet sich ein backing field von einem normalen Feld?
Wann macht es Sinn, ein read-only Feld zu deklarieren, welches keinen Standardwert zugewiesen erhält?
Wann macht es Sinn, ein read-only Feld zu deklarieren, welches einen Standardwert zugewiesen erhält?
Was sind typische Anwendungsfälle für Felder in C#?
Was sind typische Anwendungsfälle für Eigenschaften in C#?

1)a field can read and wrte while a property is able to read and write

2)
 */
public class ExampleClass
{
    // 1
    private int privateField;

    // 2
    private readonly int readonlyField;

    // 3
    private int fieldWithDefaultValue = 10;

    // 4
    private string readOnlyPropertyBackingField;
    public string ReadOnlyProperty
    {
        get { return readOnlyPropertyBackingField; }
    }

    // 5
    private string readWritePropertyBackingField;
    public string ReadWriteProperty
    {
        get { return readWritePropertyBackingField; }
        set { readWritePropertyBackingField = value; }
    }

    // 6
    private string writeOnlyPropertyBackingField;
    public string WriteOnlyProperty
    {
        set { writeOnlyPropertyBackingField = value; }
    }

    // 7
    public string AutoReadOnlyProperty { get; }

    // 8
    public string AutoReadWriteProperty { get; set; }

    // 9
    public string AutoWriteOnlyProperty { private get; set; }

    // 10
    public int ExpressionBodyProperty1 => privateField;
    public int ExpressionBodyProperty2
    {
        get => privateField;
        set => privateField = value;
    }

    // 11.
    private string initOnlyPropertyBackingField;
    public string InitOnlyProperty
    {
        get { return initOnlyPropertyBackingField; }
        init { initOnlyPropertyBackingField = value; }
    }
    
}
