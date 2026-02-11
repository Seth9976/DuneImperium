using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using voodoo;

namespace lib.src.match.dataRenderers
{
	// Token: 0x0200001F RID: 31
	public class DisableSelectableFromDisabledAttribute : VersionedDataComponentObserver<EntityComponent>
	{
		// Token: 0x0600012B RID: 299 RVA: 0x0002158C File Offset: 0x0001F78C
		// Note: this type is marked as 'beforefieldinit'.
		static DisableSelectableFromDisabledAttribute()
		{
			Il2CppClassPointerStore<DisableSelectableFromDisabledAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.src.match.dataRenderers", "DisableSelectableFromDisabledAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableSelectableFromDisabledAttribute>.NativeClassPtr);
			DisableSelectableFromDisabledAttribute.NativeFieldInfoPtr_cachedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableSelectableFromDisabledAttribute>.NativeClassPtr, "cachedState");
			DisableSelectableFromDisabledAttribute.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableSelectableFromDisabledAttribute>.NativeClassPtr, 100663532);
			DisableSelectableFromDisabledAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableSelectableFromDisabledAttribute>.NativeClassPtr, 100663533);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000215F8 File Offset: 0x0001F7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497334, XrefRangeEnd = 497346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DisableSelectableFromDisabledAttribute.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00021634 File Offset: 0x0001F834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497346, XrefRangeEnd = 497349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisableSelectableFromDisabledAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisableSelectableFromDisabledAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisableSelectableFromDisabledAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002753 File Offset: 0x00000953
		public DisableSelectableFromDisabledAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00021670 File Offset: 0x0001F870
		// (set) Token: 0x06000130 RID: 304 RVA: 0x0000275C File Offset: 0x0000095C
		public unsafe bool cachedState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisableSelectableFromDisabledAttribute.NativeFieldInfoPtr_cachedState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisableSelectableFromDisabledAttribute.NativeFieldInfoPtr_cachedState)) = value;
			}
		}

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeFieldInfoPtr_cachedState;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
