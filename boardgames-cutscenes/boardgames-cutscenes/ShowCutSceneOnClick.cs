using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x0200001D RID: 29
	public class ShowCutSceneOnClick : MonoBehaviour
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x00006134 File Offset: 0x00004334
		// Note: this type is marked as 'beforefieldinit'.
		static ShowCutSceneOnClick()
		{
			Il2CppClassPointerStore<ShowCutSceneOnClick>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-cutscenes.dll", "lotus", "ShowCutSceneOnClick");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowCutSceneOnClick>.NativeClassPtr);
			ShowCutSceneOnClick.NativeFieldInfoPtr_cutSceneKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowCutSceneOnClick>.NativeClassPtr, "cutSceneKey");
			ShowCutSceneOnClick.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowCutSceneOnClick>.NativeClassPtr, 100663479);
			ShowCutSceneOnClick.NativeMethodInfoPtr_OnClick_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowCutSceneOnClick>.NativeClassPtr, 100663480);
			ShowCutSceneOnClick.NativeMethodInfoPtr_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowCutSceneOnClick>.NativeClassPtr, 100663481);
			ShowCutSceneOnClick.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowCutSceneOnClick>.NativeClassPtr, 100663482);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000061C8 File Offset: 0x000043C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258663, XrefRangeEnd = 1258679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowCutSceneOnClick.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000061FC File Offset: 0x000043FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258679, XrefRangeEnd = 1258686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClick(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowCutSceneOnClick.NativeMethodInfoPtr_OnClick_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00006240 File Offset: 0x00004440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowCutSceneOnClick.NativeMethodInfoPtr_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00006274 File Offset: 0x00004474
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShowCutSceneOnClick()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowCutSceneOnClick>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowCutSceneOnClick.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002637 File Offset: 0x00000837
		public ShowCutSceneOnClick(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000FA RID: 250 RVA: 0x000062B0 File Offset: 0x000044B0
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00002640 File Offset: 0x00000840
		public unsafe string cutSceneKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowCutSceneOnClick.NativeFieldInfoPtr_cutSceneKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowCutSceneOnClick.NativeFieldInfoPtr_cutSceneKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeFieldInfoPtr_cutSceneKey;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_OnClick_Public_Void_EntityComponent_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_OnClick_Public_Void_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
