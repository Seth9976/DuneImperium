using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.direBytes.data
{
	// Token: 0x02000026 RID: 38
	public class SceneLinkData : DataComponent
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x0000849C File Offset: 0x0000669C
		// Note: this type is marked as 'beforefieldinit'.
		static SceneLinkData()
		{
			Il2CppClassPointerStore<SceneLinkData>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes.data", "SceneLinkData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneLinkData>.NativeClassPtr);
			SceneLinkData.NativeFieldInfoPtr__SceneLink_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLinkData>.NativeClassPtr, "<SceneLink>k__BackingField");
			SceneLinkData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLinkData>.NativeClassPtr, 100663462);
			SceneLinkData.NativeMethodInfoPtr_get_SceneLink_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLinkData>.NativeClassPtr, 100663463);
			SceneLinkData.NativeMethodInfoPtr_set_SceneLink_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLinkData>.NativeClassPtr, 100663464);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000851C File Offset: 0x0000671C
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneLinkData(string sceneLink)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneLinkData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneLink);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLinkData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00008568 File Offset: 0x00006768
		// (set) Token: 0x060001BA RID: 442 RVA: 0x000085A0 File Offset: 0x000067A0
		public unsafe string SceneLink
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLinkData.NativeMethodInfoPtr_get_SceneLink_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLinkData.NativeMethodInfoPtr_set_SceneLink_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002F3D File Offset: 0x0000113D
		public SceneLinkData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001BC RID: 444 RVA: 0x000085E4 File Offset: 0x000067E4
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00002F46 File Offset: 0x00001146
		public unsafe string _SceneLink_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneLinkData.NativeFieldInfoPtr__SceneLink_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneLinkData.NativeFieldInfoPtr__SceneLink_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr__SceneLink_k__BackingField;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_get_SceneLink_Public_get_String_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_set_SceneLink_Private_set_Void_String_0;
	}
}
