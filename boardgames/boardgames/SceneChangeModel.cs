using System;
using dwd.core.data.providers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lotus.scenes;
using UnityEngine.SceneManagement;

// Token: 0x0200001F RID: 31
public class SceneChangeModel : DataProvider
{
	// Token: 0x060000EE RID: 238 RVA: 0x000138BC File Offset: 0x00011ABC
	// Note: this type is marked as 'beforefieldinit'.
	static SceneChangeModel()
	{
		Il2CppClassPointerStore<SceneChangeModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "SceneChangeModel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneChangeModel>.NativeClassPtr);
		SceneChangeModel.NativeFieldInfoPtr_previousScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneChangeModel>.NativeClassPtr, "previousScene");
		SceneChangeModel.NativeFieldInfoPtr_LoadingScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneChangeModel>.NativeClassPtr, "LoadingScene");
		SceneChangeModel.NativeFieldInfoPtr_CurrentScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneChangeModel>.NativeClassPtr, "CurrentScene");
		SceneChangeModel.NativeFieldInfoPtr_previousStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneChangeModel>.NativeClassPtr, "previousStates");
		SceneChangeModel.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneChangeModel>.NativeClassPtr, 100663490);
		SceneChangeModel.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneChangeModel>.NativeClassPtr, 100663491);
		SceneChangeModel.NativeMethodInfoPtr_get_PreviousStateCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneChangeModel>.NativeClassPtr, 100663492);
		SceneChangeModel.NativeMethodInfoPtr_AddPreviousSceneState_Public_Void_IPreviousSceneState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneChangeModel>.NativeClassPtr, 100663493);
		SceneChangeModel.NativeMethodInfoPtr_RestorePreviousState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneChangeModel>.NativeClassPtr, 100663494);
		SceneChangeModel.NativeMethodInfoPtr_ClearStateHistory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneChangeModel>.NativeClassPtr, 100663495);
		SceneChangeModel.NativeMethodInfoPtr_IsInMatch_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneChangeModel>.NativeClassPtr, 100663496);
		SceneChangeModel.NativeMethodInfoPtr_OnLevelFinishedLoading_Private_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneChangeModel>.NativeClassPtr, 100663497);
		SceneChangeModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneChangeModel>.NativeClassPtr, 100663498);
	}

	// Token: 0x060000EF RID: 239 RVA: 0x000139F0 File Offset: 0x00011BF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983184, XrefRangeEnd = 983194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneChangeModel.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x00013A24 File Offset: 0x00011C24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983194, XrefRangeEnd = 983204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneChangeModel.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x060000F1 RID: 241 RVA: 0x00013A58 File Offset: 0x00011C58
	public unsafe int PreviousStateCount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983204, XrefRangeEnd = 983205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneChangeModel.NativeMethodInfoPtr_get_PreviousStateCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x00013A94 File Offset: 0x00011C94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983205, XrefRangeEnd = 983215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddPreviousSceneState(IPreviousSceneState state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneChangeModel.NativeMethodInfoPtr_AddPreviousSceneState_Public_Void_IPreviousSceneState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00013AD8 File Offset: 0x00011CD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983215, XrefRangeEnd = 983223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RestorePreviousState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneChangeModel.NativeMethodInfoPtr_RestorePreviousState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x00013B0C File Offset: 0x00011D0C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983223, XrefRangeEnd = 983227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearStateHistory()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneChangeModel.NativeMethodInfoPtr_ClearStateHistory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00013B40 File Offset: 0x00011D40
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 983228, RefRangeEnd = 983230, XrefRangeStart = 983227, XrefRangeEnd = 983228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsInMatch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneChangeModel.NativeMethodInfoPtr_IsInMatch_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x00013B7C File Offset: 0x00011D7C
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref scene;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneChangeModel.NativeMethodInfoPtr_OnLevelFinishedLoading_Private_Void_Scene_LoadSceneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x00013BC8 File Offset: 0x00011DC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983230, XrefRangeEnd = 983238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SceneChangeModel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneChangeModel>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneChangeModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x000026DB File Offset: 0x000008DB
	public SceneChangeModel(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x060000F9 RID: 249 RVA: 0x00013C04 File Offset: 0x00011E04
	// (set) Token: 0x060000FA RID: 250 RVA: 0x000026E4 File Offset: 0x000008E4
	public unsafe string previousScene
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneChangeModel.NativeFieldInfoPtr_previousScene);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneChangeModel.NativeFieldInfoPtr_previousScene), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x060000FB RID: 251 RVA: 0x00013C2C File Offset: 0x00011E2C
	// (set) Token: 0x060000FC RID: 252 RVA: 0x00002703 File Offset: 0x00000903
	public unsafe string LoadingScene
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneChangeModel.NativeFieldInfoPtr_LoadingScene);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneChangeModel.NativeFieldInfoPtr_LoadingScene), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060000FD RID: 253 RVA: 0x00013C54 File Offset: 0x00011E54
	// (set) Token: 0x060000FE RID: 254 RVA: 0x00002722 File Offset: 0x00000922
	public unsafe string CurrentScene
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneChangeModel.NativeFieldInfoPtr_CurrentScene);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneChangeModel.NativeFieldInfoPtr_CurrentScene), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x060000FF RID: 255 RVA: 0x00013C7C File Offset: 0x00011E7C
	// (set) Token: 0x06000100 RID: 256 RVA: 0x00002741 File Offset: 0x00000941
	public unsafe Stack<IPreviousSceneState> previousStates
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneChangeModel.NativeFieldInfoPtr_previousStates);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<IPreviousSceneState>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneChangeModel.NativeFieldInfoPtr_previousStates), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400009A RID: 154
	private static readonly IntPtr NativeFieldInfoPtr_previousScene;

	// Token: 0x0400009B RID: 155
	private static readonly IntPtr NativeFieldInfoPtr_LoadingScene;

	// Token: 0x0400009C RID: 156
	private static readonly IntPtr NativeFieldInfoPtr_CurrentScene;

	// Token: 0x0400009D RID: 157
	private static readonly IntPtr NativeFieldInfoPtr_previousStates;

	// Token: 0x0400009E RID: 158
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x0400009F RID: 159
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x040000A0 RID: 160
	private static readonly IntPtr NativeMethodInfoPtr_get_PreviousStateCount_Public_get_Int32_0;

	// Token: 0x040000A1 RID: 161
	private static readonly IntPtr NativeMethodInfoPtr_AddPreviousSceneState_Public_Void_IPreviousSceneState_0;

	// Token: 0x040000A2 RID: 162
	private static readonly IntPtr NativeMethodInfoPtr_RestorePreviousState_Public_Void_0;

	// Token: 0x040000A3 RID: 163
	private static readonly IntPtr NativeMethodInfoPtr_ClearStateHistory_Public_Void_0;

	// Token: 0x040000A4 RID: 164
	private static readonly IntPtr NativeMethodInfoPtr_IsInMatch_Public_Boolean_0;

	// Token: 0x040000A5 RID: 165
	private static readonly IntPtr NativeMethodInfoPtr_OnLevelFinishedLoading_Private_Void_Scene_LoadSceneMode_0;

	// Token: 0x040000A6 RID: 166
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
