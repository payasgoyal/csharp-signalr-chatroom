using System.Collections.Concurrent;
using FormulaOne.Chat.Models;

namespace FormulaOne.Chat.DataService;

public class SharedDb
{
    private readonly ConcurrentDictionary<string, UserConnection> _connections = new();
    
    public ConcurrentDictionary<string, UserConnection> connections => _connections;
}