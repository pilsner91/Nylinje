using Microsoft.AspNetCore.Components;

namespace BlazerWASM.StateContainer;

public class AddNewItemBeginState
{
    [Parameter]
    public int Id { get; set; }
    public int Amount { get; set; }
    public int User { get; set; }
}