module SpiralExample.Main
let cuda_kernels = """

extern "C" {
    
}
"""

type Union0 =
    | Union0Case0 of Tuple1
    | Union0Case1
and Tuple1 =
    struct
    val mem_0: float32
    new(arg_mem_0) = {mem_0 = arg_mem_0}
    end
let (var_0: (Union0 [])) = Array.zeroCreate<Union0> (System.Convert.ToInt32(8L))
let (var_1: (int64 [])) = Array.zeroCreate<int64> (System.Convert.ToInt32(8L))
let (var_2: (int64 [])) = Array.zeroCreate<int64> (System.Convert.ToInt32(8L))
let (var_3: (int64 [])) = Array.zeroCreate<int64> (System.Convert.ToInt32(8L))

