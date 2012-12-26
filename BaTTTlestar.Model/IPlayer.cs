using System;
using BaTTTlestar.Model.Data;

namespace BaTTTlestar.Model
{
    public interface IPlayer
    {
        string Name { get; }
        Board Board { set; }
        int Value { set; }

        Move Move();
    }
}
