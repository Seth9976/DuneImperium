using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.input.click
{
	// Token: 0x020000A4 RID: 164
	public static class ClickUtil : global::Il2CppSystem.Object
	{
		// Token: 0x0600078A RID: 1930 RVA: 0x0001F8C0 File Offset: 0x0001DAC0
		// Note: this type is marked as 'beforefieldinit'.
		static ClickUtil()
		{
			Il2CppClassPointerStore<ClickUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.click", "ClickUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClickUtil>.NativeClassPtr);
			ClickUtil.NativeMethodInfoPtr_IsClick_Public_Static_Boolean_Press_IClickConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickUtil>.NativeClassPtr, 100664233);
			ClickUtil.NativeMethodInfoPtr_IsSloppy_Public_Static_Boolean_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickUtil>.NativeClassPtr, 100664234);
			ClickUtil.NativeMethodInfoPtr_IsSloppy_Public_Static_Boolean_Press_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickUtil>.NativeClassPtr, 100664235);
			ClickUtil.NativeMethodInfoPtr_IsPrimaryPress_Public_Static_Boolean_PressEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickUtil>.NativeClassPtr, 100664236);
			ClickUtil.NativeMethodInfoPtr_IsPrimaryPress_Public_Static_Boolean_Press_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickUtil>.NativeClassPtr, 100664237);
			ClickUtil.NativeMethodInfoPtr_IsDraggingVertically_Public_Static_Boolean_Press_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickUtil>.NativeClassPtr, 100664238);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x0001F968 File Offset: 0x0001DB68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1126632, RefRangeEnd = 1126633, XrefRangeStart = 1126616, XrefRangeEnd = 1126632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsClick(Press press, IClickConfig config)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(config);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickUtil.NativeMethodInfoPtr_IsClick_Public_Static_Boolean_Press_IClickConfig_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0001F9BC File Offset: 0x0001DBBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1126633, RefRangeEnd = 1126634, XrefRangeStart = 1126633, XrefRangeEnd = 1126633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSloppy(Vector2 a, Vector2 b, float slopRange)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slopRange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickUtil.NativeMethodInfoPtr_IsSloppy_Public_Static_Boolean_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0001FA18 File Offset: 0x0001DC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126634, XrefRangeEnd = 1126636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSloppy(Press press, float slopRange)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slopRange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickUtil.NativeMethodInfoPtr_IsSloppy_Public_Static_Boolean_Press_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0001FA68 File Offset: 0x0001DC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126636, XrefRangeEnd = 1126651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPrimaryPress(this PressEvent evt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickUtil.NativeMethodInfoPtr_IsPrimaryPress_Public_Static_Boolean_PressEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0001FAAC File Offset: 0x0001DCAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126651, XrefRangeEnd = 1126664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPrimaryPress(this Press press)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickUtil.NativeMethodInfoPtr_IsPrimaryPress_Public_Static_Boolean_Press_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0001FAF0 File Offset: 0x0001DCF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126664, XrefRangeEnd = 1126669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDraggingVertically(this Press press)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickUtil.NativeMethodInfoPtr_IsDraggingVertically_Public_Static_Boolean_Press_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00005EEA File Offset: 0x000040EA
		public ClickUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr_IsClick_Public_Static_Boolean_Press_IClickConfig_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr_IsSloppy_Public_Static_Boolean_Vector2_Vector2_Single_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_IsSloppy_Public_Static_Boolean_Press_Single_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimaryPress_Public_Static_Boolean_PressEvent_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimaryPress_Public_Static_Boolean_Press_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_IsDraggingVertically_Public_Static_Boolean_Press_0;
	}
}
