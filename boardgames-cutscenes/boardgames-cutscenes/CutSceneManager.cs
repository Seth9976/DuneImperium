using System;
using Canis.messages;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x0200000C RID: 12
	public class CutSceneManager : MonoBehaviour
	{
		// Token: 0x0600005B RID: 91 RVA: 0x000040A4 File Offset: 0x000022A4
		// Note: this type is marked as 'beforefieldinit'.
		static CutSceneManager()
		{
			Il2CppClassPointerStore<CutSceneManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-cutscenes.dll", "lotus", "CutSceneManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutSceneManager>.NativeClassPtr);
			CutSceneManager.NativeFieldInfoPtr_vv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneManager>.NativeClassPtr, "vv");
			CutSceneManager.NativeFieldInfoPtr_cutSceneMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneManager>.NativeClassPtr, "cutSceneMap");
			CutSceneManager.NativeFieldInfoPtr_css = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneManager>.NativeClassPtr, "css");
			CutSceneManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneManager>.NativeClassPtr, 100663368);
			CutSceneManager.NativeMethodInfoPtr_AddCutScene_Public_Void_CutScene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneManager>.NativeClassPtr, 100663369);
			CutSceneManager.NativeMethodInfoPtr_PlayCutScene_Public_Command_String_CutsceneContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneManager>.NativeClassPtr, 100663370);
			CutSceneManager.NativeMethodInfoPtr_PlayCutScene_Public_Command_CutScene_CutsceneContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneManager>.NativeClassPtr, 100663371);
			CutSceneManager.NativeMethodInfoPtr_PlayCutScene_Public_Command_ShowCutScene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneManager>.NativeClassPtr, 100663372);
			CutSceneManager.NativeMethodInfoPtr_CutSceneForKey_Public_CutScene_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneManager>.NativeClassPtr, 100663373);
			CutSceneManager.NativeMethodInfoPtr_HasCutScene_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneManager>.NativeClassPtr, 100663374);
			CutSceneManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneManager>.NativeClassPtr, 100663375);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000041B0 File Offset: 0x000023B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258227, XrefRangeEnd = 1258240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000041E4 File Offset: 0x000023E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258240, XrefRangeEnd = 1258244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCutScene(CutScene cs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneManager.NativeMethodInfoPtr_AddCutScene_Public_Void_CutScene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004228 File Offset: 0x00002428
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1258262, RefRangeEnd = 1258264, XrefRangeStart = 1258244, XrefRangeEnd = 1258262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command PlayCutScene(string key, CutsceneContext cc = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneManager.NativeMethodInfoPtr_PlayCutScene_Public_Command_String_CutsceneContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000428C File Offset: 0x0000248C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258264, XrefRangeEnd = 1258279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command PlayCutScene(CutScene cutScene, CutsceneContext cc = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cutScene);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneManager.NativeMethodInfoPtr_PlayCutScene_Public_Command_CutScene_CutsceneContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000042F0 File Offset: 0x000024F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258279, XrefRangeEnd = 1258281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command PlayCutScene(ShowCutScene cutSceneMsg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cutSceneMsg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneManager.NativeMethodInfoPtr_PlayCutScene_Public_Command_ShowCutScene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004340 File Offset: 0x00002540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258281, XrefRangeEnd = 1258284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CutScene CutSceneForKey(string cutSceneKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cutSceneKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneManager.NativeMethodInfoPtr_CutSceneForKey_Public_CutScene_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CutScene>(intPtr3) : null;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004390 File Offset: 0x00002590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258284, XrefRangeEnd = 1258291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCutScene(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneManager.NativeMethodInfoPtr_HasCutScene_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000043E0 File Offset: 0x000025E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258291, XrefRangeEnd = 1258299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CutSceneManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutSceneManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002256 File Offset: 0x00000456
		public CutSceneManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000441C File Offset: 0x0000261C
		// (set) Token: 0x06000066 RID: 102 RVA: 0x0000225F File Offset: 0x0000045F
		public unsafe VoodooView vv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneManager.NativeFieldInfoPtr_vv);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneManager.NativeFieldInfoPtr_vv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0000444C File Offset: 0x0000264C
		// (set) Token: 0x06000068 RID: 104 RVA: 0x0000227E File Offset: 0x0000047E
		public unsafe LocalDataManager<string, CutScene> cutSceneMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneManager.NativeFieldInfoPtr_cutSceneMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataManager<string, CutScene>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneManager.NativeFieldInfoPtr_cutSceneMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0000447C File Offset: 0x0000267C
		// (set) Token: 0x0600006A RID: 106 RVA: 0x0000229D File Offset: 0x0000049D
		public unsafe CutSceneSession css
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneManager.NativeFieldInfoPtr_css);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CutSceneSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneManager.NativeFieldInfoPtr_css), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_vv;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_cutSceneMap;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_css;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_AddCutScene_Public_Void_CutScene_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_PlayCutScene_Public_Command_String_CutsceneContext_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_PlayCutScene_Public_Command_CutScene_CutsceneContext_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_PlayCutScene_Public_Command_ShowCutScene_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_CutSceneForKey_Public_CutScene_String_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_HasCutScene_Public_Boolean_String_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
