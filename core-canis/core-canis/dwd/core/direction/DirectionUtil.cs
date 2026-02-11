using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.direction
{
	// Token: 0x020001A5 RID: 421
	public static class DirectionUtil : global::Il2CppSystem.Object
	{
		// Token: 0x06001804 RID: 6148 RVA: 0x0007407C File Offset: 0x0007227C
		// Note: this type is marked as 'beforefieldinit'.
		static DirectionUtil()
		{
			Il2CppClassPointerStore<DirectionUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.direction", "DirectionUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectionUtil>.NativeClassPtr);
			DirectionUtil.NativeMethodInfoPtr_ToScaler_Public_Static_Single_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionUtil>.NativeClassPtr, 100667114);
			DirectionUtil.NativeMethodInfoPtr_ToScaler_Public_Static_Vector2_Direction2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionUtil>.NativeClassPtr, 100667115);
			DirectionUtil.NativeMethodInfoPtr_ToScaler_Public_Static_Vector3_Direction3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionUtil>.NativeClassPtr, 100667116);
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x000740E8 File Offset: 0x000722E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 879730, RefRangeEnd = 879731, XrefRangeStart = 879730, XrefRangeEnd = 879730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToScaler(this Direction dir)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dir;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectionUtil.NativeMethodInfoPtr_ToScaler_Public_Static_Single_Direction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00074128 File Offset: 0x00072328
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 879732, RefRangeEnd = 879733, XrefRangeStart = 879731, XrefRangeEnd = 879732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 ToScaler(this Direction2 dir)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dir;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectionUtil.NativeMethodInfoPtr_ToScaler_Public_Static_Vector2_Direction2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x00074168 File Offset: 0x00072368
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 879735, RefRangeEnd = 879736, XrefRangeStart = 879733, XrefRangeEnd = 879735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ToScaler(this Direction3 dir)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dir;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectionUtil.NativeMethodInfoPtr_ToScaler_Public_Static_Vector3_Direction3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x0000A8AE File Offset: 0x00008AAE
		public DirectionUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeMethodInfoPtr_ToScaler_Public_Static_Single_Direction_0;

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeMethodInfoPtr_ToScaler_Public_Static_Vector2_Direction2_0;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeMethodInfoPtr_ToScaler_Public_Static_Vector3_Direction3_0;
	}
}
