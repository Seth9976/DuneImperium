using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus.scenes;
using zen.analytics.messages;

// Token: 0x0200001B RID: 27
public class ChangeScene : Command
{
	// Token: 0x060000D5 RID: 213 RVA: 0x00013470 File Offset: 0x00011670
	// Note: this type is marked as 'beforefieldinit'.
	static ChangeScene()
	{
		Il2CppClassPointerStore<ChangeScene>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "ChangeScene");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeScene>.NativeClassPtr);
		ChangeScene.NativeFieldInfoPtr_scene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeScene>.NativeClassPtr, "scene");
		ChangeScene.NativeFieldInfoPtr_forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeScene>.NativeClassPtr, "forced");
		ChangeScene.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeScene>.NativeClassPtr, "state");
		ChangeScene.NativeFieldInfoPtr_model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeScene>.NativeClassPtr, "model");
		ChangeScene.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeScene>.NativeClassPtr, 100663469);
		ChangeScene.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeScene>.NativeClassPtr, 100663470);
		ChangeScene.NativeMethodInfoPtr__ctor_Public_Void_String_IPreviousSceneState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeScene>.NativeClassPtr, 100663471);
		ChangeScene.NativeMethodInfoPtr_getDefaultState_Private_IPreviousSceneState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeScene>.NativeClassPtr, 100663472);
		ChangeScene.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeScene>.NativeClassPtr, 100663473);
		ChangeScene.NativeMethodInfoPtr_dwd_core_endorsement_IRequestHandler_SceneChangeRequest__Handle_Private_Virtual_Final_New_IEnumerator_SceneChangeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeScene>.NativeClassPtr, 100663474);
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00013568 File Offset: 0x00011768
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 983135, RefRangeEnd = 983142, XrefRangeStart = 983132, XrefRangeEnd = 983135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChangeScene(string scene)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeScene>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(scene);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeScene.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x000135B4 File Offset: 0x000117B4
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 983145, RefRangeEnd = 983152, XrefRangeStart = 983142, XrefRangeEnd = 983145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChangeScene(string scene, bool forced)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeScene>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(scene);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeScene.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00013610 File Offset: 0x00011810
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 983159, RefRangeEnd = 983162, XrefRangeStart = 983152, XrefRangeEnd = 983159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChangeScene(string scene, IPreviousSceneState state, bool forced)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeScene>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(scene);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeScene.NativeMethodInfoPtr__ctor_Public_Void_String_IPreviousSceneState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x0001367C File Offset: 0x0001187C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 983164, RefRangeEnd = 983166, XrefRangeStart = 983162, XrefRangeEnd = 983164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IPreviousSceneState getDefaultState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeScene.NativeMethodInfoPtr_getDefaultState_Private_IPreviousSceneState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPreviousSceneState>(intPtr3) : null;
	}

	// Token: 0x060000DA RID: 218 RVA: 0x000136BC File Offset: 0x000118BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983166, XrefRangeEnd = 983171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IEnumerator execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChangeScene.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00013708 File Offset: 0x00011908
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983171, XrefRangeEnd = 983177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerator dwd_core_endorsement_IRequestHandler_SceneChangeRequest__Handle(SceneChangeRequest request)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeScene.NativeMethodInfoPtr_dwd_core_endorsement_IRequestHandler_SceneChangeRequest__Handle_Private_Virtual_Final_New_IEnumerator_SceneChangeRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00002594 File Offset: 0x00000794
	public ChangeScene(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x060000DD RID: 221 RVA: 0x00013758 File Offset: 0x00011958
	// (set) Token: 0x060000DE RID: 222 RVA: 0x0000259D File Offset: 0x0000079D
	public unsafe string scene
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene.NativeFieldInfoPtr_scene);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene.NativeFieldInfoPtr_scene), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x060000DF RID: 223 RVA: 0x00013780 File Offset: 0x00011980
	// (set) Token: 0x060000E0 RID: 224 RVA: 0x000025BC File Offset: 0x000007BC
	public unsafe bool forced
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene.NativeFieldInfoPtr_forced);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene.NativeFieldInfoPtr_forced)) = value;
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x060000E1 RID: 225 RVA: 0x000137A8 File Offset: 0x000119A8
	// (set) Token: 0x060000E2 RID: 226 RVA: 0x000025D7 File Offset: 0x000007D7
	public unsafe IPreviousSceneState state
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene.NativeFieldInfoPtr_state);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPreviousSceneState>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x060000E3 RID: 227 RVA: 0x000137D8 File Offset: 0x000119D8
	// (set) Token: 0x060000E4 RID: 228 RVA: 0x000025F6 File Offset: 0x000007F6
	public unsafe SceneChangeModel model
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene.NativeFieldInfoPtr_model);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneChangeModel>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene.NativeFieldInfoPtr_model), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400008D RID: 141
	private static readonly IntPtr NativeFieldInfoPtr_scene;

	// Token: 0x0400008E RID: 142
	private static readonly IntPtr NativeFieldInfoPtr_forced;

	// Token: 0x0400008F RID: 143
	private static readonly IntPtr NativeFieldInfoPtr_state;

	// Token: 0x04000090 RID: 144
	private static readonly IntPtr NativeFieldInfoPtr_model;

	// Token: 0x04000091 RID: 145
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x04000092 RID: 146
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

	// Token: 0x04000093 RID: 147
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IPreviousSceneState_Boolean_0;

	// Token: 0x04000094 RID: 148
	private static readonly IntPtr NativeMethodInfoPtr_getDefaultState_Private_IPreviousSceneState_0;

	// Token: 0x04000095 RID: 149
	private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

	// Token: 0x04000096 RID: 150
	private static readonly IntPtr NativeMethodInfoPtr_dwd_core_endorsement_IRequestHandler_SceneChangeRequest__Handle_Private_Virtual_Final_New_IEnumerator_SceneChangeRequest_0;

	// Token: 0x0200019A RID: 410
	[ObfuscatedName("ChangeScene+<dwd-core-endorsement-IRequestHandler<SceneChangeRequest>-Handle>d__9")]
	public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique : Object
	{
		// Token: 0x060013F4 RID: 5108 RVA: 0x0004EB1C File Offset: 0x0004CD1C
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique()
		{
			Il2CppClassPointerStore<ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeScene>.NativeClassPtr, "<dwd-core-endorsement-IRequestHandler<SceneChangeRequest>-Handle>d__9");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique>.NativeClassPtr);
			ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique>.NativeClassPtr, "<>1__state");
			ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique>.NativeClassPtr, "<>2__current");
			ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique>.NativeClassPtr, "request");
			ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique>.NativeClassPtr, "<>4__this");
			ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique>.NativeClassPtr, 100663475);
			ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique>.NativeClassPtr, 100663476);
			ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique>.NativeClassPtr, 100663477);
			ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique>.NativeClassPtr, 100663478);
			ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique>.NativeClassPtr, 100663479);
			ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique>.NativeClassPtr, 100663480);
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x0004EC10 File Offset: 0x0004CE10
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x0004EC58 File Offset: 0x0004CE58
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x0004EC8C File Offset: 0x0004CE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982983, XrefRangeEnd = 982997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x0004ECC8 File Offset: 0x0004CEC8
		public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x0004ED08 File Offset: 0x0004CF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982997, XrefRangeEnd = 983002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x0004ED3C File Offset: 0x0004CF3C
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x0000B4D7 File Offset: 0x000096D7
		public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x0004ED7C File Offset: 0x0004CF7C
		// (set) Token: 0x060013FD RID: 5117 RVA: 0x0000B4E0 File Offset: 0x000096E0
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x0004EDA4 File Offset: 0x0004CFA4
		// (set) Token: 0x060013FF RID: 5119 RVA: 0x0000B4FB File Offset: 0x000096FB
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x0004EDD4 File Offset: 0x0004CFD4
		// (set) Token: 0x06001401 RID: 5121 RVA: 0x0000B51A File Offset: 0x0000971A
		public unsafe SceneChangeRequest request
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeFieldInfoPtr_request);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneChangeRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x0004EE04 File Offset: 0x0004D004
		// (set) Token: 0x06001403 RID: 5123 RVA: 0x0000B539 File Offset: 0x00009739
		public unsafe ChangeScene __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChangeScene>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObScreChObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeFieldInfoPtr_request;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x0200019B RID: 411
	[ObfuscatedName("ChangeScene+<execute>d__8")]
	public sealed class _execute_d__8 : Object
	{
		// Token: 0x06001404 RID: 5124 RVA: 0x0004EE34 File Offset: 0x0004D034
		// Note: this type is marked as 'beforefieldinit'.
		static _execute_d__8()
		{
			Il2CppClassPointerStore<ChangeScene._execute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeScene>.NativeClassPtr, "<execute>d__8");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeScene._execute_d__8>.NativeClassPtr);
			ChangeScene._execute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeScene._execute_d__8>.NativeClassPtr, "<>1__state");
			ChangeScene._execute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeScene._execute_d__8>.NativeClassPtr, "<>2__current");
			ChangeScene._execute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeScene._execute_d__8>.NativeClassPtr, "<>4__this");
			ChangeScene._execute_d__8.NativeFieldInfoPtr__endorser_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeScene._execute_d__8>.NativeClassPtr, "<endorser>5__2");
			ChangeScene._execute_d__8.NativeFieldInfoPtr__request_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeScene._execute_d__8>.NativeClassPtr, "<request>5__3");
			ChangeScene._execute_d__8.NativeFieldInfoPtr__sceneChangeStartMsg_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeScene._execute_d__8>.NativeClassPtr, "<sceneChangeStartMsg>5__4");
			ChangeScene._execute_d__8.NativeFieldInfoPtr__performanceMetrics_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeScene._execute_d__8>.NativeClassPtr, "<performanceMetrics>5__5");
			ChangeScene._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeScene._execute_d__8>.NativeClassPtr, 100663481);
			ChangeScene._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeScene._execute_d__8>.NativeClassPtr, 100663482);
			ChangeScene._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeScene._execute_d__8>.NativeClassPtr, 100663483);
			ChangeScene._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeScene._execute_d__8>.NativeClassPtr, 100663484);
			ChangeScene._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeScene._execute_d__8>.NativeClassPtr, 100663485);
			ChangeScene._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeScene._execute_d__8>.NativeClassPtr, 100663486);
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x0004EF64 File Offset: 0x0004D164
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _execute_d__8(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeScene._execute_d__8>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeScene._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x0004EFAC File Offset: 0x0004D1AC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeScene._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x0004EFE0 File Offset: 0x0004D1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983002, XrefRangeEnd = 983127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeScene._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x0004F01C File Offset: 0x0004D21C
		public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeScene._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x0004F05C File Offset: 0x0004D25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983127, XrefRangeEnd = 983132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeScene._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x0004F090 File Offset: 0x0004D290
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangeScene._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x0000B558 File Offset: 0x00009758
		public _execute_d__8(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x0004F0D0 File Offset: 0x0004D2D0
		// (set) Token: 0x0600140D RID: 5133 RVA: 0x0000B561 File Offset: 0x00009761
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene._execute_d__8.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene._execute_d__8.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x0004F0F8 File Offset: 0x0004D2F8
		// (set) Token: 0x0600140F RID: 5135 RVA: 0x0000B57C File Offset: 0x0000977C
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene._execute_d__8.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene._execute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x0004F128 File Offset: 0x0004D328
		// (set) Token: 0x06001411 RID: 5137 RVA: 0x0000B59B File Offset: 0x0000979B
		public unsafe ChangeScene __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene._execute_d__8.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChangeScene>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene._execute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x0004F158 File Offset: 0x0004D358
		// (set) Token: 0x06001413 RID: 5139 RVA: 0x0000B5BA File Offset: 0x000097BA
		public unsafe SceneChangeEndorser _endorser_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene._execute_d__8.NativeFieldInfoPtr__endorser_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneChangeEndorser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene._execute_d__8.NativeFieldInfoPtr__endorser_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x0004F188 File Offset: 0x0004D388
		// (set) Token: 0x06001415 RID: 5141 RVA: 0x0000B5D9 File Offset: 0x000097D9
		public unsafe SceneChangeRequest _request_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene._execute_d__8.NativeFieldInfoPtr__request_5__3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneChangeRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene._execute_d__8.NativeFieldInfoPtr__request_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x0004F1B8 File Offset: 0x0004D3B8
		// (set) Token: 0x06001417 RID: 5143 RVA: 0x0000B5F8 File Offset: 0x000097F8
		public unsafe AnalyticsSceneChangeStart _sceneChangeStartMsg_5__4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene._execute_d__8.NativeFieldInfoPtr__sceneChangeStartMsg_5__4);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnalyticsSceneChangeStart>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene._execute_d__8.NativeFieldInfoPtr__sceneChangeStartMsg_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x0004F1E8 File Offset: 0x0004D3E8
		// (set) Token: 0x06001419 RID: 5145 RVA: 0x0000B617 File Offset: 0x00009817
		public unsafe PerformanceMetrics _performanceMetrics_5__5
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene._execute_d__8.NativeFieldInfoPtr__performanceMetrics_5__5);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PerformanceMetrics>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangeScene._execute_d__8.NativeFieldInfoPtr__performanceMetrics_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeFieldInfoPtr__endorser_5__2;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeFieldInfoPtr__request_5__3;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeFieldInfoPtr__sceneChangeStartMsg_5__4;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeFieldInfoPtr__performanceMetrics_5__5;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
