using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using TMPro;
using voodoo;

namespace boardgames.dataRenderers
{
	// Token: 0x02000144 RID: 324
	public sealed class DescriptionRenderer : VersionedDataComponentObserver<BasicDescription>
	{
		// Token: 0x06000ED3 RID: 3795 RVA: 0x0004CDA4 File Offset: 0x0004AFA4
		// Note: this type is marked as 'beforefieldinit'.
		static DescriptionRenderer()
		{
			Il2CppClassPointerStore<DescriptionRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "DescriptionRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DescriptionRenderer>.NativeClassPtr);
			DescriptionRenderer.NativeFieldInfoPtr_nameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriptionRenderer>.NativeClassPtr, "nameText");
			DescriptionRenderer.NativeMethodInfoPtr_clear_Private_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionRenderer>.NativeClassPtr, 100665456);
			DescriptionRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionRenderer>.NativeClassPtr, 100665457);
			DescriptionRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionRenderer>.NativeClassPtr, 100665458);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0004CE24 File Offset: 0x0004B024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512694, XrefRangeEnd = 512697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void clear(PoolableItem poolable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(poolable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptionRenderer.NativeMethodInfoPtr_clear_Private_Void_PoolableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x0004CE68 File Offset: 0x0004B068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512697, XrefRangeEnd = 512721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptionRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x0004CE9C File Offset: 0x0004B09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512721, XrefRangeEnd = 512724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DescriptionRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DescriptionRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriptionRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00009244 File Offset: 0x00007444
		public DescriptionRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x0004CED8 File Offset: 0x0004B0D8
		// (set) Token: 0x06000ED9 RID: 3801 RVA: 0x0000924D File Offset: 0x0000744D
		public unsafe TMP_Text nameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriptionRenderer.NativeFieldInfoPtr_nameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriptionRenderer.NativeFieldInfoPtr_nameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeFieldInfoPtr_nameText;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeMethodInfoPtr_clear_Private_Void_PoolableItem_0;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
