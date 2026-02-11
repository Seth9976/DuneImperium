using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.VFX
{
	// Token: 0x02000009 RID: 9
	public sealed class VFXSpawnerState : Object
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x000046B0 File Offset: 0x000028B0
		// Note: this type is marked as 'beforefieldinit'.
		static VFXSpawnerState()
		{
			Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXSpawnerState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr);
			VFXSpawnerState.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, "m_Ptr");
			VFXSpawnerState.NativeFieldInfoPtr_m_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, "m_Owner");
			VFXSpawnerState.NativeFieldInfoPtr_m_WrapEventAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, "m_WrapEventAttribute");
			VFXSpawnerState.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663317);
			VFXSpawnerState.NativeMethodInfoPtr_CreateSpawnerStateWrapper_Internal_Static_VFXSpawnerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663318);
			VFXSpawnerState.NativeMethodInfoPtr_PrepareWrapper_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663319);
			VFXSpawnerState.NativeMethodInfoPtr_SetWrapValue_Internal_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663320);
			VFXSpawnerState.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663321);
			VFXSpawnerState.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663322);
			VFXSpawnerState.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663323);
			VFXSpawnerState.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663324);
			VFXSpawnerState.Internal_CreateDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.Internal_CreateDelegate>("UnityEngine.VFX.VFXSpawnerState::Internal_Create");
			VFXSpawnerState.get_newLoopDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.get_newLoopDelegate>("UnityEngine.VFX.VFXSpawnerState::get_newLoop");
			VFXSpawnerState.get_loopStateDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.get_loopStateDelegate>("UnityEngine.VFX.VFXSpawnerState::get_loopState");
			VFXSpawnerState.set_loopStateDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.set_loopStateDelegate>("UnityEngine.VFX.VFXSpawnerState::set_loopState");
			VFXSpawnerState.get_spawnCountDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.get_spawnCountDelegate>("UnityEngine.VFX.VFXSpawnerState::get_spawnCount");
			VFXSpawnerState.set_spawnCountDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.set_spawnCountDelegate>("UnityEngine.VFX.VFXSpawnerState::set_spawnCount");
			VFXSpawnerState.get_deltaTimeDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.get_deltaTimeDelegate>("UnityEngine.VFX.VFXSpawnerState::get_deltaTime");
			VFXSpawnerState.set_deltaTimeDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.set_deltaTimeDelegate>("UnityEngine.VFX.VFXSpawnerState::set_deltaTime");
			VFXSpawnerState.get_totalTimeDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.get_totalTimeDelegate>("UnityEngine.VFX.VFXSpawnerState::get_totalTime");
			VFXSpawnerState.set_totalTimeDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.set_totalTimeDelegate>("UnityEngine.VFX.VFXSpawnerState::set_totalTime");
			VFXSpawnerState.get_delayBeforeLoopDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.get_delayBeforeLoopDelegate>("UnityEngine.VFX.VFXSpawnerState::get_delayBeforeLoop");
			VFXSpawnerState.set_delayBeforeLoopDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.set_delayBeforeLoopDelegate>("UnityEngine.VFX.VFXSpawnerState::set_delayBeforeLoop");
			VFXSpawnerState.get_loopDurationDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.get_loopDurationDelegate>("UnityEngine.VFX.VFXSpawnerState::get_loopDuration");
			VFXSpawnerState.set_loopDurationDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.set_loopDurationDelegate>("UnityEngine.VFX.VFXSpawnerState::set_loopDuration");
			VFXSpawnerState.get_delayAfterLoopDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.get_delayAfterLoopDelegate>("UnityEngine.VFX.VFXSpawnerState::get_delayAfterLoop");
			VFXSpawnerState.set_delayAfterLoopDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.set_delayAfterLoopDelegate>("UnityEngine.VFX.VFXSpawnerState::set_delayAfterLoop");
			VFXSpawnerState.get_loopIndexDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.get_loopIndexDelegate>("UnityEngine.VFX.VFXSpawnerState::get_loopIndex");
			VFXSpawnerState.set_loopIndexDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.set_loopIndexDelegate>("UnityEngine.VFX.VFXSpawnerState::set_loopIndex");
			VFXSpawnerState.get_loopCountDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.get_loopCountDelegate>("UnityEngine.VFX.VFXSpawnerState::get_loopCount");
			VFXSpawnerState.set_loopCountDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.set_loopCountDelegate>("UnityEngine.VFX.VFXSpawnerState::set_loopCount");
			VFXSpawnerState.Internal_GetVFXEventAttributeDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.Internal_GetVFXEventAttributeDelegate>("UnityEngine.VFX.VFXSpawnerState::Internal_GetVFXEventAttribute");
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000048F8 File Offset: 0x00002AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269761, XrefRangeEnd = 1269762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VFXSpawnerState(IntPtr ptr, bool owner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr))
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref owner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXSpawnerState.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00004950 File Offset: 0x00002B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269762, XrefRangeEnd = 1269772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VFXSpawnerState CreateSpawnerStateWrapper()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXSpawnerState.NativeMethodInfoPtr_CreateSpawnerStateWrapper_Internal_Static_VFXSpawnerState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VFXSpawnerState>(intPtr3) : null;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00004984 File Offset: 0x00002B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269772, XrefRangeEnd = 1269790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareWrapper()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXSpawnerState.NativeMethodInfoPtr_PrepareWrapper_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000049B8 File Offset: 0x00002BB8
		[CallerCount(0)]
		public unsafe void SetWrapValue(IntPtr ptrToSpawnerState, IntPtr ptrToEventAttribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ptrToSpawnerState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ptrToEventAttribute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXSpawnerState.NativeMethodInfoPtr_SetWrapValue_Internal_Void_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00004A04 File Offset: 0x00002C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269790, XrefRangeEnd = 1269794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXSpawnerState.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00004A38 File Offset: 0x00002C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269794, XrefRangeEnd = 1269801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXSpawnerState.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00004A6C File Offset: 0x00002C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269801, XrefRangeEnd = 1269809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXSpawnerState.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00004AA0 File Offset: 0x00002CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269809, XrefRangeEnd = 1269811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Destroy(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXSpawnerState.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000026F4 File Offset: 0x000008F4
		public VFXSpawnerState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00004AD4 File Offset: 0x00002CD4
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000026FD File Offset: 0x000008FD
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXSpawnerState.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXSpawnerState.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00004AFC File Offset: 0x00002CFC
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00002718 File Offset: 0x00000918
		public unsafe bool m_Owner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXSpawnerState.NativeFieldInfoPtr_m_Owner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXSpawnerState.NativeFieldInfoPtr_m_Owner)) = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00004B24 File Offset: 0x00002D24
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00002733 File Offset: 0x00000933
		public unsafe VFXEventAttribute m_WrapEventAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXSpawnerState.NativeFieldInfoPtr_m_WrapEventAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VFXEventAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXSpawnerState.NativeFieldInfoPtr_m_WrapEventAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002752 File Offset: 0x00000952
		public static IntPtr Internal_Create()
		{
			return VFXSpawnerState.Internal_CreateDelegateField();
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00004B54 File Offset: 0x00002D54
		public IntPtr GetPtr()
		{
			return this.m_Ptr;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00004B6C File Offset: 0x00002D6C
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0000275E File Offset: 0x0000095E
		public bool playing
		{
			get
			{
				return this.loopState == VFXSpawnerLoopState.Looping;
			}
			set
			{
				this.loopState = (value ? VFXSpawnerLoopState.Looping : VFXSpawnerLoopState.Finished);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000276F File Offset: 0x0000096F
		public bool newLoop
		{
			get
			{
				return VFXSpawnerState.get_newLoopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00002781 File Offset: 0x00000981
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00002793 File Offset: 0x00000993
		public VFXSpawnerLoopState loopState
		{
			get
			{
				return VFXSpawnerState.get_loopStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VFXSpawnerState.set_loopStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x000027A6 File Offset: 0x000009A6
		// (set) Token: 0x060000CA RID: 202 RVA: 0x000027B8 File Offset: 0x000009B8
		public float spawnCount
		{
			get
			{
				return VFXSpawnerState.get_spawnCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VFXSpawnerState.set_spawnCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000027CB File Offset: 0x000009CB
		// (set) Token: 0x060000CC RID: 204 RVA: 0x000027DD File Offset: 0x000009DD
		public float deltaTime
		{
			get
			{
				return VFXSpawnerState.get_deltaTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VFXSpawnerState.set_deltaTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000CD RID: 205 RVA: 0x000027F0 File Offset: 0x000009F0
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00002802 File Offset: 0x00000A02
		public float totalTime
		{
			get
			{
				return VFXSpawnerState.get_totalTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VFXSpawnerState.set_totalTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00002815 File Offset: 0x00000A15
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00002827 File Offset: 0x00000A27
		public float delayBeforeLoop
		{
			get
			{
				return VFXSpawnerState.get_delayBeforeLoopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VFXSpawnerState.set_delayBeforeLoopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000283A File Offset: 0x00000A3A
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000284C File Offset: 0x00000A4C
		public float loopDuration
		{
			get
			{
				return VFXSpawnerState.get_loopDurationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VFXSpawnerState.set_loopDurationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000285F File Offset: 0x00000A5F
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00002871 File Offset: 0x00000A71
		public float delayAfterLoop
		{
			get
			{
				return VFXSpawnerState.get_delayAfterLoopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VFXSpawnerState.set_delayAfterLoopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00002884 File Offset: 0x00000A84
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002896 File Offset: 0x00000A96
		public int loopIndex
		{
			get
			{
				return VFXSpawnerState.get_loopIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VFXSpawnerState.set_loopIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000028A9 File Offset: 0x00000AA9
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x000028BB File Offset: 0x00000ABB
		public int loopCount
		{
			get
			{
				return VFXSpawnerState.get_loopCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VFXSpawnerState.set_loopCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00004B88 File Offset: 0x00002D88
		public VFXEventAttribute Internal_GetVFXEventAttribute()
		{
			IntPtr intPtr = VFXSpawnerState.Internal_GetVFXEventAttributeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<VFXEventAttribute>(intPtr2) : null;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00004BB4 File Offset: 0x00002DB4
		public VFXEventAttribute vfxEventAttribute
		{
			get
			{
				bool flag = !this.m_Owner && this.m_WrapEventAttribute != null;
				VFXEventAttribute vfxeventAttribute;
				if (flag)
				{
					vfxeventAttribute = this.m_WrapEventAttribute;
				}
				else
				{
					vfxeventAttribute = this.Internal_GetVFXEventAttribute();
				}
				return vfxeventAttribute;
			}
		}

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr_m_Owner;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_m_WrapEventAttribute;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_CreateSpawnerStateWrapper_Internal_Static_VFXSpawnerState_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_PrepareWrapper_Private_Void_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_SetWrapValue_Internal_Void_IntPtr_IntPtr_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;

		// Token: 0x0400006F RID: 111
		private static readonly VFXSpawnerState.Internal_CreateDelegate Internal_CreateDelegateField;

		// Token: 0x04000070 RID: 112
		private static readonly VFXSpawnerState.get_newLoopDelegate get_newLoopDelegateField;

		// Token: 0x04000071 RID: 113
		private static readonly VFXSpawnerState.get_loopStateDelegate get_loopStateDelegateField;

		// Token: 0x04000072 RID: 114
		private static readonly VFXSpawnerState.set_loopStateDelegate set_loopStateDelegateField;

		// Token: 0x04000073 RID: 115
		private static readonly VFXSpawnerState.get_spawnCountDelegate get_spawnCountDelegateField;

		// Token: 0x04000074 RID: 116
		private static readonly VFXSpawnerState.set_spawnCountDelegate set_spawnCountDelegateField;

		// Token: 0x04000075 RID: 117
		private static readonly VFXSpawnerState.get_deltaTimeDelegate get_deltaTimeDelegateField;

		// Token: 0x04000076 RID: 118
		private static readonly VFXSpawnerState.set_deltaTimeDelegate set_deltaTimeDelegateField;

		// Token: 0x04000077 RID: 119
		private static readonly VFXSpawnerState.get_totalTimeDelegate get_totalTimeDelegateField;

		// Token: 0x04000078 RID: 120
		private static readonly VFXSpawnerState.set_totalTimeDelegate set_totalTimeDelegateField;

		// Token: 0x04000079 RID: 121
		private static readonly VFXSpawnerState.get_delayBeforeLoopDelegate get_delayBeforeLoopDelegateField;

		// Token: 0x0400007A RID: 122
		private static readonly VFXSpawnerState.set_delayBeforeLoopDelegate set_delayBeforeLoopDelegateField;

		// Token: 0x0400007B RID: 123
		private static readonly VFXSpawnerState.get_loopDurationDelegate get_loopDurationDelegateField;

		// Token: 0x0400007C RID: 124
		private static readonly VFXSpawnerState.set_loopDurationDelegate set_loopDurationDelegateField;

		// Token: 0x0400007D RID: 125
		private static readonly VFXSpawnerState.get_delayAfterLoopDelegate get_delayAfterLoopDelegateField;

		// Token: 0x0400007E RID: 126
		private static readonly VFXSpawnerState.set_delayAfterLoopDelegate set_delayAfterLoopDelegateField;

		// Token: 0x0400007F RID: 127
		private static readonly VFXSpawnerState.get_loopIndexDelegate get_loopIndexDelegateField;

		// Token: 0x04000080 RID: 128
		private static readonly VFXSpawnerState.set_loopIndexDelegate set_loopIndexDelegateField;

		// Token: 0x04000081 RID: 129
		private static readonly VFXSpawnerState.get_loopCountDelegate get_loopCountDelegateField;

		// Token: 0x04000082 RID: 130
		private static readonly VFXSpawnerState.set_loopCountDelegate set_loopCountDelegateField;

		// Token: 0x04000083 RID: 131
		private static readonly VFXSpawnerState.Internal_GetVFXEventAttributeDelegate Internal_GetVFXEventAttributeDelegateField;

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x06000207 RID: 519
		private delegate IntPtr Internal_CreateDelegate();

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x06000209 RID: 521
		private delegate bool get_newLoopDelegate(IntPtr @this);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x0600020B RID: 523
		private delegate VFXSpawnerLoopState get_loopStateDelegate(IntPtr @this);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x0600020D RID: 525
		private delegate void set_loopStateDelegate(IntPtr @this, VFXSpawnerLoopState value);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x0600020F RID: 527
		private delegate float get_spawnCountDelegate(IntPtr @this);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x06000211 RID: 529
		private delegate void set_spawnCountDelegate(IntPtr @this, float value);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x06000213 RID: 531
		private delegate float get_deltaTimeDelegate(IntPtr @this);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x06000215 RID: 533
		private delegate void set_deltaTimeDelegate(IntPtr @this, float value);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000217 RID: 535
		private delegate float get_totalTimeDelegate(IntPtr @this);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x06000219 RID: 537
		private delegate void set_totalTimeDelegate(IntPtr @this, float value);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x0600021B RID: 539
		private delegate float get_delayBeforeLoopDelegate(IntPtr @this);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x0600021D RID: 541
		private delegate void set_delayBeforeLoopDelegate(IntPtr @this, float value);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x0600021F RID: 543
		private delegate float get_loopDurationDelegate(IntPtr @this);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x06000221 RID: 545
		private delegate void set_loopDurationDelegate(IntPtr @this, float value);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x06000223 RID: 547
		private delegate float get_delayAfterLoopDelegate(IntPtr @this);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x06000225 RID: 549
		private delegate void set_delayAfterLoopDelegate(IntPtr @this, float value);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x06000227 RID: 551
		private delegate int get_loopIndexDelegate(IntPtr @this);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x06000229 RID: 553
		private delegate void set_loopIndexDelegate(IntPtr @this, int value);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x0600022B RID: 555
		private delegate int get_loopCountDelegate(IntPtr @this);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x0600022D RID: 557
		private delegate void set_loopCountDelegate(IntPtr @this, int value);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x0600022F RID: 559
		private delegate IntPtr Internal_GetVFXEventAttributeDelegate(IntPtr @this);
	}
}
