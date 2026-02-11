using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x02000063 RID: 99
	public static class MarshalUtility : Object
	{
		// Token: 0x0600096B RID: 2411 RVA: 0x00028D48 File Offset: 0x00026F48
		// Note: this type is marked as 'beforefieldinit'.
		static MarshalUtility()
		{
			Il2CppClassPointerStore<MarshalUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "MarshalUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarshalUtility>.NativeClassPtr);
			MarshalUtility.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalUtility>.NativeClassPtr, "buffer");
			MarshalUtility.NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalUtility>.NativeClassPtr, 100664508);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00028DA0 File Offset: 0x00026FA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 786800, RefRangeEnd = 786801, XrefRangeStart = 786783, XrefRangeEnd = 786800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(IntPtr source, Il2CppStructArray<uint> destination, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarshalUtility.NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00005C98 File Offset: 0x00003E98
		public MarshalUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x00028DF4 File Offset: 0x00026FF4
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x00005CA1 File Offset: 0x00003EA1
		public unsafe static Il2CppStructArray<int> buffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MarshalUtility.NativeFieldInfoPtr_buffer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MarshalUtility.NativeFieldInfoPtr_buffer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_UInt32_Int32_0;
	}
}
