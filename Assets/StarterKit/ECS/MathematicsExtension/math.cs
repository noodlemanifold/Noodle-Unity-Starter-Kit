using System.Runtime.CompilerServices;

namespace Unity.Mathematics {

public static partial class math {

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float modRight(float dividend, float divisor) {
        return dividend - divisor * floor(dividend / divisor);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double modRight(double dividend, double divisor) {
        return dividend - divisor * floor(dividend / divisor);
    }
}
}
