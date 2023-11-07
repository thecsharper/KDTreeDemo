using KdTree.Math;
using KdTree;

var tree = new KdTree<float, int>(2, new FloatMath())
{
    { new[] { 50.0f, 80.0f }, 100 },
    { new[] { 20.0f, 10.0f }, 200 }
};

var nodes = tree.GetNearestNeighbours(new[] { 30.0f, 20.0f }, 1);


foreach (var node in nodes)
{
    Console.WriteLine($"{node.Point.FirstOrDefault()} {node.Value}");
}

