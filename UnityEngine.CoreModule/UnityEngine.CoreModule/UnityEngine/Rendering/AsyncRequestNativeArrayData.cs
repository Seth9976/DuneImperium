using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Rendering
{
	// Token: 0x020001DE RID: 478
	[StructLayout(2)]
	public struct AsyncRequestNativeArrayData
	{
		// Token: 0x060021A3 RID: 8611 RVA: 0x00093C38 File Offset: 0x00091E38
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncRequestNativeArrayData()
		{
			Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "AsyncRequestNativeArrayData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr);
			AsyncRequestNativeArrayData.NativeFieldInfoPtr_nativeArrayBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr, "nativeArrayBuffer");
			AsyncRequestNativeArrayData.NativeFieldInfoPtr_lengthInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr, "lengthInBytes");
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x0000CDD8 File Offset: 0x0000AFD8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr, ref this));
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x00093C90 File Offset: 0x00091E90
		public static AsyncRequestNativeArrayData CreateAndCheckAccess<T>(Unity.Collections.NativeArray<T> array) where T : struct
		{
			bool flag = array.m_AllocatorLabel == Unity.Collections.Allocator.Temp || array.m_AllocatorLabel == Unity.Collections.Allocator.TempJob;
			if (flag)
			{
				throw new ArgumentException("AsyncGPUReadback cannot use Temp memory as input since the result may only become available at an unspecified point in the future.");
			}
			return new AsyncRequestNativeArrayData
			{
				nativeArrayBuffer = array.GetUnsafePtr<T>(),
				lengthInBytes = (long)array.Length * (long)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>()
			};
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x00093CF4 File Offset: 0x00091EF4
		public static AsyncRequestNativeArrayData CreateAndCheckAccess<T>(Unity.Collections.NativeSlice<T> array) where T : struct
		{
			return new AsyncRequestNativeArrayData
			{
				nativeArrayBuffer = array.GetUnsafePtr<T>(),
				lengthInBytes = (long)array.Length * (long)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>()
			};
		}

		// Token: 0x04001C9D RID: 7325
		private static readonly IntPtr NativeFieldInfoPtr_nativeArrayBuffer;

		// Token: 0x04001C9E RID: 7326
		private static readonly IntPtr NativeFieldInfoPtr_lengthInBytes;

		// Token: 0x04001C9F RID: 7327
		[FieldOffset(0)]
		public IntPtr nativeArrayBuffer;

		// Token: 0x04001CA0 RID: 7328
		[FieldOffset(8)]
		public long lengthInBytes;
	}
}
