#include <cuda.h> 
#include <device_launch_parameters.h> 
#include <builtin_types.h> 
#include "float.h"

#define _SIZE_T_DEFINED 
#ifndef __CUDACC__ 
#define __CUDACC__ 
#endif 
#ifndef __cplusplus 
#define __cplusplus 
#endif

extern "C" {
	// Device code
	__global__ void FFT(short* A, int N)
	{
		int i = blockDim.x * blockIdx.x + threadIdx.x;
		if (i < N)
			A[i] = A[i] + A[i];
	}
}