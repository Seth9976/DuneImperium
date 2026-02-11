using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.input
{
	// Token: 0x0200004E RID: 78
	public class MouseButtonFilter : PressFilter
	{
		// Token: 0x0600028B RID: 651 RVA: 0x0000EDE4 File Offset: 0x0000CFE4
		// Note: this type is marked as 'beforefieldinit'.
		static MouseButtonFilter()
		{
			Il2CppClassPointerStore<MouseButtonFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "MouseButtonFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseButtonFilter>.NativeClassPtr);
			MouseButtonFilter.NativeFieldInfoPtr_mouseFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseButtonFilter>.NativeClassPtr, "mouseFlags");
			MouseButtonFilter.NativeMethodInfoPtr_Matches_Public_Virtual_Boolean_Press_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseButtonFilter>.NativeClassPtr, 100663612);
			MouseButtonFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseButtonFilter>.NativeClassPtr, 100663613);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000EE50 File Offset: 0x0000D050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120846, XrefRangeEnd = 1120848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Matches(Press press)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseButtonFilter.NativeMethodInfoPtr_Matches_Public_Virtual_Boolean_Press_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000EEA8 File Offset: 0x0000D0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseButtonFilter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseButtonFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseButtonFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00003765 File Offset: 0x00001965
		public MouseButtonFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600028F RID: 655 RVA: 0x0000EEE4 File Offset: 0x0000D0E4
		// (set) Token: 0x06000290 RID: 656 RVA: 0x0000376E File Offset: 0x0000196E
		public unsafe MouseButtonFilter.MouseButtonFlags mouseFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseButtonFilter.NativeFieldInfoPtr_mouseFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseButtonFilter.NativeFieldInfoPtr_mouseFlags)) = value;
			}
		}

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeFieldInfoPtr_mouseFlags;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Virtual_Boolean_Press_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C1 RID: 193
		[Flags]
		public enum MouseButtonFlags
		{
			// Token: 0x0400055F RID: 1375
			Left = 1,
			// Token: 0x04000560 RID: 1376
			Right = 2,
			// Token: 0x04000561 RID: 1377
			Middle = 4
		}
	}
}
