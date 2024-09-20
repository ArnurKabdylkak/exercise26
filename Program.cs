using Packt.Shared;

Rectangle rect = new(height: 3, width: 4.5);
WriteLine($"Rectangle H: {rect.Height}, W: {rect.Width}, Area: {rect.Area}");

Square sq = new(5);
WriteLine($"Square    H: {sq.Height}, W: {sq.Width}, Area: {sq.Area}");

Circle circ = new(radius: 2.5);
WriteLine($"Circle    H: {circ.Height}, W: {circ.Width}, Area: {circ.Area}");
