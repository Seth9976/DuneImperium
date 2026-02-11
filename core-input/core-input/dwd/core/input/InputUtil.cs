using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.input
{
	// Token: 0x0200004B RID: 75
	public static class InputUtil : global::Il2CppSystem.Object
	{
		// Token: 0x0600026B RID: 619 RVA: 0x0000E730 File Offset: 0x0000C930
		// Note: this type is marked as 'beforefieldinit'.
		static InputUtil()
		{
			Il2CppClassPointerStore<InputUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "InputUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputUtil>.NativeClassPtr);
			InputUtil.NativeFieldInfoPtr_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputUtil>.NativeClassPtr, "cache");
			InputUtil.NativeMethodInfoPtr_GetSample_Public_Static_InputSample_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUtil>.NativeClassPtr, 100663597);
			InputUtil.NativeMethodInfoPtr_GetSample_Public_Static_InputSample_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUtil>.NativeClassPtr, 100663598);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000E79C File Offset: 0x0000C99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120748, XrefRangeEnd = 1120752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputSample GetSample(Vector2 screenPosition)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputUtil.NativeMethodInfoPtr_GetSample_Public_Static_InputSample_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new InputSample(intPtr);
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000E7D4 File Offset: 0x0000C9D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1120788, RefRangeEnd = 1120791, XrefRangeStart = 1120752, XrefRangeEnd = 1120788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputSample GetSample(Vector2 screenPosition, bool allowOffCameraRectHits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowOffCameraRectHits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputUtil.NativeMethodInfoPtr_GetSample_Public_Static_InputSample_Vector2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new InputSample(intPtr);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x000036A1 File Offset: 0x000018A1
		public InputUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0000E81C File Offset: 0x0000CA1C
		// (set) Token: 0x06000270 RID: 624 RVA: 0x000036AA File Offset: 0x000018AA
		public unsafe static List<Transform> cache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputUtil.NativeFieldInfoPtr_cache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputUtil.NativeFieldInfoPtr_cache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr_cache;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_GetSample_Public_Static_InputSample_Vector2_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_GetSample_Public_Static_InputSample_Vector2_Boolean_0;
	}
}
