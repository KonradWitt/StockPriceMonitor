using System.Collections.Generic;

public class Option
{
    public int expirationDate { get; set; }
    public bool hasMiniOptions { get; set; }
    public List<Call> calls { get; set; }
    public List<Put> puts { get; set; }
}
