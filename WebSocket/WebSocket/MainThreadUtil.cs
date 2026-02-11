using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Threading;
using UnityEngine;

// Token: 0x02000005 RID: 5
public class MainThreadUtil : MonoBehaviour
{
	// Token: 0x0600000F RID: 15 RVA: 0x00002D98 File Offset: 0x00000F98
	// Note: this type is marked as 'beforefieldinit'.
	static MainThreadUtil()
	{
		Il2CppClassPointerStore<MainThreadUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("WebSocket.dll", "", "MainThreadUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainThreadUtil>.NativeClassPtr);
		MainThreadUtil.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainThreadUtil>.NativeClassPtr, "<Instance>k__BackingField");
		MainThreadUtil.NativeFieldInfoPtr__synchronizationContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainThreadUtil>.NativeClassPtr, "<synchronizationContext>k__BackingField");
		MainThreadUtil.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainThreadUtil>.NativeClassPtr, "initialized");
		MainThreadUtil.NativeMethodInfoPtr_get_Instance_Public_Static_get_MainThreadUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainThreadUtil>.NativeClassPtr, 100663301);
		MainThreadUtil.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_MainThreadUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainThreadUtil>.NativeClassPtr, 100663302);
		MainThreadUtil.NativeMethodInfoPtr_get_synchronizationContext_Public_Static_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainThreadUtil>.NativeClassPtr, 100663303);
		MainThreadUtil.NativeMethodInfoPtr_set_synchronizationContext_Private_Static_set_Void_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainThreadUtil>.NativeClassPtr, 100663304);
		MainThreadUtil.NativeMethodInfoPtr_Setup_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainThreadUtil>.NativeClassPtr, 100663305);
		MainThreadUtil.NativeMethodInfoPtr_Run_Public_Static_Void_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainThreadUtil>.NativeClassPtr, 100663306);
		MainThreadUtil.NativeMethodInfoPtr_Run_Public_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainThreadUtil>.NativeClassPtr, 100663307);
		MainThreadUtil.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainThreadUtil>.NativeClassPtr, 100663308);
		MainThreadUtil.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainThreadUtil>.NativeClassPtr, 100663309);
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000010 RID: 16 RVA: 0x00002EB8 File Offset: 0x000010B8
	// (set) Token: 0x06000011 RID: 17 RVA: 0x00002EEC File Offset: 0x000010EC
	public unsafe static MainThreadUtil Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262334, XrefRangeEnd = 1262336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainThreadUtil.NativeMethodInfoPtr_get_Instance_Public_Static_get_MainThreadUtil_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MainThreadUtil>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262336, XrefRangeEnd = 1262340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainThreadUtil.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_MainThreadUtil_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000012 RID: 18 RVA: 0x00002F24 File Offset: 0x00001124
	// (set) Token: 0x06000013 RID: 19 RVA: 0x00002F58 File Offset: 0x00001158
	public unsafe static SynchronizationContext synchronizationContext
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262340, XrefRangeEnd = 1262342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainThreadUtil.NativeMethodInfoPtr_get_synchronizationContext_Public_Static_get_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262342, XrefRangeEnd = 1262346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainThreadUtil.NativeMethodInfoPtr_set_synchronizationContext_Private_Static_set_Void_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002F90 File Offset: 0x00001190
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262346, XrefRangeEnd = 1262366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Setup()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainThreadUtil.NativeMethodInfoPtr_Setup_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002FB8 File Offset: 0x000011B8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1262408, RefRangeEnd = 1262409, XrefRangeStart = 1262366, XrefRangeEnd = 1262408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Run(IEnumerator waitForUpdate)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitForUpdate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainThreadUtil.NativeMethodInfoPtr_Run_Public_Static_Void_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002FF0 File Offset: 0x000011F0
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1262423, RefRangeEnd = 1262427, XrefRangeStart = 1262409, XrefRangeEnd = 1262423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Run(Action action)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainThreadUtil.NativeMethodInfoPtr_Run_Public_Static_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00003028 File Offset: 0x00001228
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262427, XrefRangeEnd = 1262435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainThreadUtil.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000018 RID: 24 RVA: 0x0000305C File Offset: 0x0000125C
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MainThreadUtil()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainThreadUtil>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainThreadUtil.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000020DE File Offset: 0x000002DE
	public MainThreadUtil(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600001A RID: 26 RVA: 0x00003098 File Offset: 0x00001298
	// (set) Token: 0x0600001B RID: 27 RVA: 0x000020E7 File Offset: 0x000002E7
	public unsafe static MainThreadUtil _Instance_k__BackingField
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(MainThreadUtil.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainThreadUtil>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(MainThreadUtil.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x0600001C RID: 28 RVA: 0x000030C0 File Offset: 0x000012C0
	// (set) Token: 0x0600001D RID: 29 RVA: 0x000020F9 File Offset: 0x000002F9
	public unsafe static SynchronizationContext _synchronizationContext_k__BackingField
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(MainThreadUtil.NativeFieldInfoPtr__synchronizationContext_k__BackingField, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(MainThreadUtil.NativeFieldInfoPtr__synchronizationContext_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600001E RID: 30 RVA: 0x000030E8 File Offset: 0x000012E8
	// (set) Token: 0x0600001F RID: 31 RVA: 0x0000210B File Offset: 0x0000030B
	public unsafe static bool initialized
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(MainThreadUtil.NativeFieldInfoPtr_initialized, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(MainThreadUtil.NativeFieldInfoPtr_initialized, (void*)(&value));
		}
	}

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeFieldInfoPtr__synchronizationContext_k__BackingField;

	// Token: 0x04000009 RID: 9
	private static readonly IntPtr NativeFieldInfoPtr_initialized;

	// Token: 0x0400000A RID: 10
	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_MainThreadUtil_0;

	// Token: 0x0400000B RID: 11
	private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_MainThreadUtil_0;

	// Token: 0x0400000C RID: 12
	private static readonly IntPtr NativeMethodInfoPtr_get_synchronizationContext_Public_Static_get_SynchronizationContext_0;

	// Token: 0x0400000D RID: 13
	private static readonly IntPtr NativeMethodInfoPtr_set_synchronizationContext_Private_Static_set_Void_SynchronizationContext_0;

	// Token: 0x0400000E RID: 14
	private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Static_Void_0;

	// Token: 0x0400000F RID: 15
	private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Static_Void_IEnumerator_0;

	// Token: 0x04000010 RID: 16
	private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Static_Void_Action_0;

	// Token: 0x04000011 RID: 17
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000012 RID: 18
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200000E RID: 14
	[ObfuscatedName("MainThreadUtil+<>c__DisplayClass10_0")]
	public sealed class __c__DisplayClass10_0 : global::Il2CppSystem.Object
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00003DEC File Offset: 0x00001FEC
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass10_0()
		{
			Il2CppClassPointerStore<MainThreadUtil.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainThreadUtil>.NativeClassPtr, "<>c__DisplayClass10_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainThreadUtil.__c__DisplayClass10_0>.NativeClassPtr);
			MainThreadUtil.__c__DisplayClass10_0.NativeFieldInfoPtr_waitForUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainThreadUtil.__c__DisplayClass10_0>.NativeClassPtr, "waitForUpdate");
			MainThreadUtil.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainThreadUtil.__c__DisplayClass10_0>.NativeClassPtr, 100663310);
			MainThreadUtil.__c__DisplayClass10_0.NativeMethodInfoPtr__Run_b__0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainThreadUtil.__c__DisplayClass10_0>.NativeClassPtr, 100663311);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003E54 File Offset: 0x00002054
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass10_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainThreadUtil.__c__DisplayClass10_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainThreadUtil.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003E90 File Offset: 0x00002090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262330, XrefRangeEnd = 1262334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Run_b__0(global::Il2CppSystem.Object _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainThreadUtil.__c__DisplayClass10_0.NativeMethodInfoPtr__Run_b__0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002300 File Offset: 0x00000500
		public __c__DisplayClass10_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00003ED4 File Offset: 0x000020D4
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00002309 File Offset: 0x00000509
		public unsafe IEnumerator waitForUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainThreadUtil.__c__DisplayClass10_0.NativeFieldInfoPtr_waitForUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainThreadUtil.__c__DisplayClass10_0.NativeFieldInfoPtr_waitForUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_waitForUpdate;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr__Run_b__0_Internal_Void_Object_0;
	}

	// Token: 0x0200000F RID: 15
	[ObfuscatedName("MainThreadUtil+<>c__DisplayClass11_0")]
	public sealed class __c__DisplayClass11_0 : global::Il2CppSystem.Object
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00003F04 File Offset: 0x00002104
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass11_0()
		{
			Il2CppClassPointerStore<MainThreadUtil.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainThreadUtil>.NativeClassPtr, "<>c__DisplayClass11_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainThreadUtil.__c__DisplayClass11_0>.NativeClassPtr);
			MainThreadUtil.__c__DisplayClass11_0.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainThreadUtil.__c__DisplayClass11_0>.NativeClassPtr, "action");
			MainThreadUtil.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainThreadUtil.__c__DisplayClass11_0>.NativeClassPtr, 100663312);
			MainThreadUtil.__c__DisplayClass11_0.NativeMethodInfoPtr__Run_b__0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainThreadUtil.__c__DisplayClass11_0>.NativeClassPtr, 100663313);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003F6C File Offset: 0x0000216C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass11_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainThreadUtil.__c__DisplayClass11_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainThreadUtil.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003FA8 File Offset: 0x000021A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Run_b__0(global::Il2CppSystem.Object _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainThreadUtil.__c__DisplayClass11_0.NativeMethodInfoPtr__Run_b__0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002328 File Offset: 0x00000528
		public __c__DisplayClass11_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00003FEC File Offset: 0x000021EC
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002331 File Offset: 0x00000531
		public unsafe Action action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainThreadUtil.__c__DisplayClass11_0.NativeFieldInfoPtr_action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainThreadUtil.__c__DisplayClass11_0.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_action;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr__Run_b__0_Internal_Void_Object_0;
	}
}
