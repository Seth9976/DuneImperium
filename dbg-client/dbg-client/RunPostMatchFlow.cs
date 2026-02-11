using System;
using boardgames.match.data;
using Canis.utils.localization;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000010 RID: 16
public class RunPostMatchFlow : Command
{
	// Token: 0x06000086 RID: 134 RVA: 0x0001F170 File Offset: 0x0001D370
	// Note: this type is marked as 'beforefieldinit'.
	static RunPostMatchFlow()
	{
		Il2CppClassPointerStore<RunPostMatchFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "", "RunPostMatchFlow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunPostMatchFlow>.NativeClassPtr);
		RunPostMatchFlow.NativeFieldInfoPtr_gameOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPostMatchFlow>.NativeClassPtr, "gameOptions");
		RunPostMatchFlow.NativeFieldInfoPtr_returnToMenus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPostMatchFlow>.NativeClassPtr, "returnToMenus");
		RunPostMatchFlow.NativeFieldInfoPtr_dailyChallengeScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPostMatchFlow>.NativeClassPtr, "dailyChallengeScore");
		RunPostMatchFlow.NativeMethodInfoPtr__ctor_Public_Void_GameOptionsData_Boolean_Dictionary_2_LocalizableTextVariables_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPostMatchFlow>.NativeClassPtr, 100663400);
		RunPostMatchFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPostMatchFlow>.NativeClassPtr, 100663401);
		RunPostMatchFlow.NativeMethodInfoPtr_GetDestinationFlow_Protected_Virtual_New_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPostMatchFlow>.NativeClassPtr, 100663402);
		RunPostMatchFlow.NativeMethodInfoPtr_getDestinationFlow_Private_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPostMatchFlow>.NativeClassPtr, 100663403);
		RunPostMatchFlow.NativeMethodInfoPtr_MarkChallengeSeen_Private_Static_Void_GameOptionsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPostMatchFlow>.NativeClassPtr, 100663404);
	}

	// Token: 0x06000087 RID: 135 RVA: 0x0001F240 File Offset: 0x0001D440
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 495693, RefRangeEnd = 495694, XrefRangeStart = 495690, XrefRangeEnd = 495693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RunPostMatchFlow(GameOptionsData gameOptions, bool returnToMenus = false, Dictionary<LocalizableTextVariables, int> dailyChallengeScore = null)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunPostMatchFlow>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameOptions);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnToMenus;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dailyChallengeScore);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPostMatchFlow.NativeMethodInfoPtr__ctor_Public_Void_GameOptionsData_Boolean_Dictionary_2_LocalizableTextVariables_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000088 RID: 136 RVA: 0x0001F2AC File Offset: 0x0001D4AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495694, XrefRangeEnd = 495699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IEnumerator execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunPostMatchFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000089 RID: 137 RVA: 0x0001F2F8 File Offset: 0x0001D4F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495699, XrefRangeEnd = 495700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Command GetDestinationFlow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunPostMatchFlow.NativeMethodInfoPtr_GetDestinationFlow_Protected_Virtual_New_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
	}

	// Token: 0x0600008A RID: 138 RVA: 0x0001F344 File Offset: 0x0001D544
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 495710, RefRangeEnd = 495711, XrefRangeStart = 495700, XrefRangeEnd = 495710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Command getDestinationFlow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPostMatchFlow.NativeMethodInfoPtr_getDestinationFlow_Private_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
	}

	// Token: 0x0600008B RID: 139 RVA: 0x0001F384 File Offset: 0x0001D584
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495711, XrefRangeEnd = 495733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MarkChallengeSeen(GameOptionsData gameOptions)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPostMatchFlow.NativeMethodInfoPtr_MarkChallengeSeen_Private_Static_Void_GameOptionsData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600008C RID: 140 RVA: 0x000023C0 File Offset: 0x000005C0
	public RunPostMatchFlow(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x0600008D RID: 141 RVA: 0x0001F3BC File Offset: 0x0001D5BC
	// (set) Token: 0x0600008E RID: 142 RVA: 0x000023C9 File Offset: 0x000005C9
	public unsafe GameOptionsData gameOptions
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPostMatchFlow.NativeFieldInfoPtr_gameOptions);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameOptionsData>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPostMatchFlow.NativeFieldInfoPtr_gameOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x0600008F RID: 143 RVA: 0x0001F3EC File Offset: 0x0001D5EC
	// (set) Token: 0x06000090 RID: 144 RVA: 0x000023E8 File Offset: 0x000005E8
	public unsafe bool returnToMenus
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPostMatchFlow.NativeFieldInfoPtr_returnToMenus);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPostMatchFlow.NativeFieldInfoPtr_returnToMenus)) = value;
		}
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x06000091 RID: 145 RVA: 0x0001F414 File Offset: 0x0001D614
	// (set) Token: 0x06000092 RID: 146 RVA: 0x00002403 File Offset: 0x00000603
	public unsafe Dictionary<LocalizableTextVariables, int> dailyChallengeScore
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPostMatchFlow.NativeFieldInfoPtr_dailyChallengeScore);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<LocalizableTextVariables, int>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPostMatchFlow.NativeFieldInfoPtr_dailyChallengeScore), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000051 RID: 81
	private static readonly IntPtr NativeFieldInfoPtr_gameOptions;

	// Token: 0x04000052 RID: 82
	private static readonly IntPtr NativeFieldInfoPtr_returnToMenus;

	// Token: 0x04000053 RID: 83
	private static readonly IntPtr NativeFieldInfoPtr_dailyChallengeScore;

	// Token: 0x04000054 RID: 84
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameOptionsData_Boolean_Dictionary_2_LocalizableTextVariables_Int32_0;

	// Token: 0x04000055 RID: 85
	private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

	// Token: 0x04000056 RID: 86
	private static readonly IntPtr NativeMethodInfoPtr_GetDestinationFlow_Protected_Virtual_New_Command_0;

	// Token: 0x04000057 RID: 87
	private static readonly IntPtr NativeMethodInfoPtr_getDestinationFlow_Private_Command_0;

	// Token: 0x04000058 RID: 88
	private static readonly IntPtr NativeMethodInfoPtr_MarkChallengeSeen_Private_Static_Void_GameOptionsData_0;

	// Token: 0x020002CC RID: 716
	[ObfuscatedName("RunPostMatchFlow+<>c__DisplayClass4_0")]
	public sealed class __c__DisplayClass4_0 : Object
	{
		// Token: 0x060021A1 RID: 8609 RVA: 0x0008D268 File Offset: 0x0008B468
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass4_0()
		{
			Il2CppClassPointerStore<RunPostMatchFlow.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunPostMatchFlow>.NativeClassPtr, "<>c__DisplayClass4_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunPostMatchFlow.__c__DisplayClass4_0>.NativeClassPtr);
			RunPostMatchFlow.__c__DisplayClass4_0.NativeFieldInfoPtr_sceneChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPostMatchFlow.__c__DisplayClass4_0>.NativeClassPtr, "sceneChange");
			RunPostMatchFlow.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPostMatchFlow.__c__DisplayClass4_0>.NativeClassPtr, 100663405);
			RunPostMatchFlow.__c__DisplayClass4_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPostMatchFlow.__c__DisplayClass4_0>.NativeClassPtr, 100663406);
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x0008D2D0 File Offset: 0x0008B4D0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass4_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunPostMatchFlow.__c__DisplayClass4_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPostMatchFlow.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x0008D30C File Offset: 0x0008B50C
		[CallerCount(0)]
		public unsafe bool _execute_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPostMatchFlow.__c__DisplayClass4_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x00011921 File Offset: 0x0000FB21
		public __c__DisplayClass4_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x060021A5 RID: 8613 RVA: 0x0008D348 File Offset: 0x0008B548
		// (set) Token: 0x060021A6 RID: 8614 RVA: 0x0001192A File Offset: 0x0000FB2A
		public unsafe ChangeScene sceneChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPostMatchFlow.__c__DisplayClass4_0.NativeFieldInfoPtr_sceneChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChangeScene>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPostMatchFlow.__c__DisplayClass4_0.NativeFieldInfoPtr_sceneChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400152D RID: 5421
		private static readonly IntPtr NativeFieldInfoPtr_sceneChange;

		// Token: 0x0400152E RID: 5422
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400152F RID: 5423
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_Boolean_0;
	}

	// Token: 0x020002CD RID: 717
	[ObfuscatedName("RunPostMatchFlow+<execute>d__4")]
	public sealed class _execute_d__4 : Object
	{
		// Token: 0x060021A7 RID: 8615 RVA: 0x0008D378 File Offset: 0x0008B578
		// Note: this type is marked as 'beforefieldinit'.
		static _execute_d__4()
		{
			Il2CppClassPointerStore<RunPostMatchFlow._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunPostMatchFlow>.NativeClassPtr, "<execute>d__4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunPostMatchFlow._execute_d__4>.NativeClassPtr);
			RunPostMatchFlow._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPostMatchFlow._execute_d__4>.NativeClassPtr, "<>1__state");
			RunPostMatchFlow._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPostMatchFlow._execute_d__4>.NativeClassPtr, "<>2__current");
			RunPostMatchFlow._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPostMatchFlow._execute_d__4>.NativeClassPtr, "<>4__this");
			RunPostMatchFlow._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPostMatchFlow._execute_d__4>.NativeClassPtr, 100663407);
			RunPostMatchFlow._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPostMatchFlow._execute_d__4>.NativeClassPtr, 100663408);
			RunPostMatchFlow._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPostMatchFlow._execute_d__4>.NativeClassPtr, 100663409);
			RunPostMatchFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPostMatchFlow._execute_d__4>.NativeClassPtr, 100663410);
			RunPostMatchFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPostMatchFlow._execute_d__4>.NativeClassPtr, 100663411);
			RunPostMatchFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPostMatchFlow._execute_d__4>.NativeClassPtr, 100663412);
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x0008D458 File Offset: 0x0008B658
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _execute_d__4(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunPostMatchFlow._execute_d__4>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPostMatchFlow._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x0008D4A0 File Offset: 0x0008B6A0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPostMatchFlow._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x0008D4D4 File Offset: 0x0008B6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495593, XrefRangeEnd = 495685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPostMatchFlow._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x060021AB RID: 8619 RVA: 0x0008D510 File Offset: 0x0008B710
		public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPostMatchFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x0008D550 File Offset: 0x0008B750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495685, XrefRangeEnd = 495690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPostMatchFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x060021AD RID: 8621 RVA: 0x0008D584 File Offset: 0x0008B784
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPostMatchFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x00011949 File Offset: 0x0000FB49
		public _execute_d__4(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x0008D5C4 File Offset: 0x0008B7C4
		// (set) Token: 0x060021B0 RID: 8624 RVA: 0x00011952 File Offset: 0x0000FB52
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPostMatchFlow._execute_d__4.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPostMatchFlow._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x0008D5EC File Offset: 0x0008B7EC
		// (set) Token: 0x060021B2 RID: 8626 RVA: 0x0001196D File Offset: 0x0000FB6D
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPostMatchFlow._execute_d__4.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPostMatchFlow._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x060021B3 RID: 8627 RVA: 0x0008D61C File Offset: 0x0008B81C
		// (set) Token: 0x060021B4 RID: 8628 RVA: 0x0001198C File Offset: 0x0000FB8C
		public unsafe RunPostMatchFlow __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPostMatchFlow._execute_d__4.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunPostMatchFlow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPostMatchFlow._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001530 RID: 5424
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001531 RID: 5425
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001532 RID: 5426
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001534 RID: 5428
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001535 RID: 5429
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
