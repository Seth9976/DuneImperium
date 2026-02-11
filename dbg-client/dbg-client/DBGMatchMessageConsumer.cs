using System;
using Canis.messages;
using dwd.core;
using dwd.core.commands;
using dwd.core.match.delorean;
using dwd.core.match.sequence.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using zen.match;

// Token: 0x02000014 RID: 20
public class DBGMatchMessageConsumer : MonoBehaviour
{
	// Token: 0x060000A9 RID: 169 RVA: 0x0001F910 File Offset: 0x0001DB10
	// Note: this type is marked as 'beforefieldinit'.
	static DBGMatchMessageConsumer()
	{
		Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "", "DBGMatchMessageConsumer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr);
		DBGMatchMessageConsumer.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, "<Initialized>k__BackingField");
		DBGMatchMessageConsumer.NativeFieldInfoPtr_messageQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, "messageQueue");
		DBGMatchMessageConsumer.NativeFieldInfoPtr_commandQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, "commandQueue");
		DBGMatchMessageConsumer.NativeFieldInfoPtr_delorean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, "delorean");
		DBGMatchMessageConsumer.NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, "running");
		DBGMatchMessageConsumer.NativeFieldInfoPtr_coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, "coroutine");
		DBGMatchMessageConsumer.NativeFieldInfoPtr_AnimationIgnoredTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, "AnimationIgnoredTypes");
		DBGMatchMessageConsumer.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, 100663423);
		DBGMatchMessageConsumer.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, 100663424);
		DBGMatchMessageConsumer.NativeMethodInfoPtr_Suspend_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, 100663425);
		DBGMatchMessageConsumer.NativeMethodInfoPtr_Resume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, 100663426);
		DBGMatchMessageConsumer.NativeMethodInfoPtr_SkipToResults_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, 100663427);
		DBGMatchMessageConsumer.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, 100663428);
		DBGMatchMessageConsumer.NativeMethodInfoPtr_createSequenceFactory_Protected_Virtual_New_SequenceCommandFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, 100663429);
		DBGMatchMessageConsumer.NativeMethodInfoPtr_createSequenceParser_Protected_Virtual_New_ISequenceToCommandFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, 100663430);
		DBGMatchMessageConsumer.NativeMethodInfoPtr_animationShouldIgnore_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, 100663431);
		DBGMatchMessageConsumer.NativeMethodInfoPtr_TerminateEarly_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, 100663432);
		DBGMatchMessageConsumer.NativeMethodInfoPtr_messagePredicate_Private_Static_Boolean_IGameMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, 100663433);
		DBGMatchMessageConsumer.NativeMethodInfoPtr_commandPredicate_Private_Static_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, 100663434);
		DBGMatchMessageConsumer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, 100663435);
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x060000AA RID: 170 RVA: 0x0001FAD0 File Offset: 0x0001DCD0
	// (set) Token: 0x060000AB RID: 171 RVA: 0x0001FB0C File Offset: 0x0001DD0C
	public unsafe bool Initialized
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchMessageConsumer.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchMessageConsumer.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x060000AC RID: 172 RVA: 0x0001FB4C File Offset: 0x0001DD4C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 495896, RefRangeEnd = 495898, XrefRangeStart = 495896, XrefRangeEnd = 495896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Suspend()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchMessageConsumer.NativeMethodInfoPtr_Suspend_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000AD RID: 173 RVA: 0x0001FB80 File Offset: 0x0001DD80
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 483004, RefRangeEnd = 483006, XrefRangeStart = 483004, XrefRangeEnd = 483006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Resume()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchMessageConsumer.NativeMethodInfoPtr_Resume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000AE RID: 174 RVA: 0x0001FBB4 File Offset: 0x0001DDB4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 495899, RefRangeEnd = 495900, XrefRangeStart = 495898, XrefRangeEnd = 495899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SkipToResults()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchMessageConsumer.NativeMethodInfoPtr_SkipToResults_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000AF RID: 175 RVA: 0x0001FBE8 File Offset: 0x0001DDE8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495900, XrefRangeEnd = 495905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchMessageConsumer.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x0001FC28 File Offset: 0x0001DE28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495905, XrefRangeEnd = 495924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual SequenceCommandFactory createSequenceFactory()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGMatchMessageConsumer.NativeMethodInfoPtr_createSequenceFactory_Protected_Virtual_New_SequenceCommandFactory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceCommandFactory>(intPtr3) : null;
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x0001FC74 File Offset: 0x0001DE74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495924, XrefRangeEnd = 495928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ISequenceToCommandFactory createSequenceParser()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGMatchMessageConsumer.NativeMethodInfoPtr_createSequenceParser_Protected_Virtual_New_ISequenceToCommandFactory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISequenceToCommandFactory>(intPtr3) : null;
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x0001FCC0 File Offset: 0x0001DEC0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495928, XrefRangeEnd = 495949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool animationShouldIgnore(global::Il2CppSystem.Object msg)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchMessageConsumer.NativeMethodInfoPtr_animationShouldIgnore_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x0001FD04 File Offset: 0x0001DF04
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 496003, RefRangeEnd = 496006, XrefRangeStart = 495949, XrefRangeEnd = 496003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TerminateEarly()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchMessageConsumer.NativeMethodInfoPtr_TerminateEarly_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x0001FD38 File Offset: 0x0001DF38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496006, XrefRangeEnd = 496007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool messagePredicate(IGameMessage msg)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchMessageConsumer.NativeMethodInfoPtr_messagePredicate_Private_Static_Boolean_IGameMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x0001FD7C File Offset: 0x0001DF7C
	[CallerCount(184)]
	[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool commandPredicate(Command cmd)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchMessageConsumer.NativeMethodInfoPtr_commandPredicate_Private_Static_Boolean_Command_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x0001FDC0 File Offset: 0x0001DFC0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 496008, RefRangeEnd = 496009, XrefRangeStart = 496007, XrefRangeEnd = 496008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DBGMatchMessageConsumer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchMessageConsumer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x0000249A File Offset: 0x0000069A
	public DBGMatchMessageConsumer(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x060000B8 RID: 184 RVA: 0x0001FDFC File Offset: 0x0001DFFC
	// (set) Token: 0x060000B9 RID: 185 RVA: 0x000024A3 File Offset: 0x000006A3
	public unsafe bool _Initialized_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageConsumer.NativeFieldInfoPtr__Initialized_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageConsumer.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x060000BA RID: 186 RVA: 0x0001FE24 File Offset: 0x0001E024
	// (set) Token: 0x060000BB RID: 187 RVA: 0x000024BE File Offset: 0x000006BE
	public unsafe SimpleGameMessageQueue messageQueue
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageConsumer.NativeFieldInfoPtr_messageQueue);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleGameMessageQueue>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageConsumer.NativeFieldInfoPtr_messageQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x060000BC RID: 188 RVA: 0x0001FE54 File Offset: 0x0001E054
	// (set) Token: 0x060000BD RID: 189 RVA: 0x000024DD File Offset: 0x000006DD
	public unsafe MatchCommandQueue commandQueue
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageConsumer.NativeFieldInfoPtr_commandQueue);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchCommandQueue>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageConsumer.NativeFieldInfoPtr_commandQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x060000BE RID: 190 RVA: 0x0001FE84 File Offset: 0x0001E084
	// (set) Token: 0x060000BF RID: 191 RVA: 0x000024FC File Offset: 0x000006FC
	public unsafe Delorean delorean
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageConsumer.NativeFieldInfoPtr_delorean);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Delorean>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageConsumer.NativeFieldInfoPtr_delorean), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x060000C0 RID: 192 RVA: 0x0001FEB4 File Offset: 0x0001E0B4
	// (set) Token: 0x060000C1 RID: 193 RVA: 0x0000251B File Offset: 0x0000071B
	public unsafe bool running
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageConsumer.NativeFieldInfoPtr_running);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageConsumer.NativeFieldInfoPtr_running)) = value;
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x060000C2 RID: 194 RVA: 0x0001FEDC File Offset: 0x0001E0DC
	// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002536 File Offset: 0x00000736
	public unsafe IEnumerator coroutine
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageConsumer.NativeFieldInfoPtr_coroutine);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageConsumer.NativeFieldInfoPtr_coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x060000C4 RID: 196 RVA: 0x0001FF0C File Offset: 0x0001E10C
	// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002555 File Offset: 0x00000755
	public unsafe static List<Type> AnimationIgnoredTypes
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(DBGMatchMessageConsumer.NativeFieldInfoPtr_AnimationIgnoredTypes, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(DBGMatchMessageConsumer.NativeFieldInfoPtr_AnimationIgnoredTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000066 RID: 102
	private static readonly IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

	// Token: 0x04000067 RID: 103
	private static readonly IntPtr NativeFieldInfoPtr_messageQueue;

	// Token: 0x04000068 RID: 104
	private static readonly IntPtr NativeFieldInfoPtr_commandQueue;

	// Token: 0x04000069 RID: 105
	private static readonly IntPtr NativeFieldInfoPtr_delorean;

	// Token: 0x0400006A RID: 106
	private static readonly IntPtr NativeFieldInfoPtr_running;

	// Token: 0x0400006B RID: 107
	private static readonly IntPtr NativeFieldInfoPtr_coroutine;

	// Token: 0x0400006C RID: 108
	private static readonly IntPtr NativeFieldInfoPtr_AnimationIgnoredTypes;

	// Token: 0x0400006D RID: 109
	private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

	// Token: 0x0400006E RID: 110
	private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0;

	// Token: 0x0400006F RID: 111
	private static readonly IntPtr NativeMethodInfoPtr_Suspend_Public_Void_0;

	// Token: 0x04000070 RID: 112
	private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Void_0;

	// Token: 0x04000071 RID: 113
	private static readonly IntPtr NativeMethodInfoPtr_SkipToResults_Public_Void_0;

	// Token: 0x04000072 RID: 114
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

	// Token: 0x04000073 RID: 115
	private static readonly IntPtr NativeMethodInfoPtr_createSequenceFactory_Protected_Virtual_New_SequenceCommandFactory_0;

	// Token: 0x04000074 RID: 116
	private static readonly IntPtr NativeMethodInfoPtr_createSequenceParser_Protected_Virtual_New_ISequenceToCommandFactory_0;

	// Token: 0x04000075 RID: 117
	private static readonly IntPtr NativeMethodInfoPtr_animationShouldIgnore_Private_Static_Boolean_Object_0;

	// Token: 0x04000076 RID: 118
	private static readonly IntPtr NativeMethodInfoPtr_TerminateEarly_Public_Void_0;

	// Token: 0x04000077 RID: 119
	private static readonly IntPtr NativeMethodInfoPtr_messagePredicate_Private_Static_Boolean_IGameMessage_0;

	// Token: 0x04000078 RID: 120
	private static readonly IntPtr NativeMethodInfoPtr_commandPredicate_Private_Static_Boolean_Command_0;

	// Token: 0x04000079 RID: 121
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020002CE RID: 718
	[ObfuscatedName("DBGMatchMessageConsumer+<>O")]
	public static class __O : global::Il2CppSystem.Object
	{
		// Token: 0x060021B5 RID: 8629 RVA: 0x0008D64C File Offset: 0x0008B84C
		// Note: this type is marked as 'beforefieldinit'.
		static __O()
		{
			Il2CppClassPointerStore<DBGMatchMessageConsumer.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, "<>O");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGMatchMessageConsumer.__O>.NativeClassPtr);
			DBGMatchMessageConsumer.__O.NativeFieldInfoPtr__0___animationShouldIgnore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchMessageConsumer.__O>.NativeClassPtr, "<0>__animationShouldIgnore");
			DBGMatchMessageConsumer.__O.NativeFieldInfoPtr__1___messagePredicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchMessageConsumer.__O>.NativeClassPtr, "<1>__messagePredicate");
			DBGMatchMessageConsumer.__O.NativeFieldInfoPtr__2___commandPredicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchMessageConsumer.__O>.NativeClassPtr, "<2>__commandPredicate");
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x000119AB File Offset: 0x0000FBAB
		public __O(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x060021B7 RID: 8631 RVA: 0x0008D6B4 File Offset: 0x0008B8B4
		// (set) Token: 0x060021B8 RID: 8632 RVA: 0x000119B4 File Offset: 0x0000FBB4
		public unsafe static Predicate<global::Il2CppSystem.Object> _0___animationShouldIgnore
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGMatchMessageConsumer.__O.NativeFieldInfoPtr__0___animationShouldIgnore, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<global::Il2CppSystem.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGMatchMessageConsumer.__O.NativeFieldInfoPtr__0___animationShouldIgnore, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x0008D6DC File Offset: 0x0008B8DC
		// (set) Token: 0x060021BA RID: 8634 RVA: 0x000119C6 File Offset: 0x0000FBC6
		public unsafe static Func<IGameMessage, bool> _1___messagePredicate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGMatchMessageConsumer.__O.NativeFieldInfoPtr__1___messagePredicate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGameMessage, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGMatchMessageConsumer.__O.NativeFieldInfoPtr__1___messagePredicate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x0008D704 File Offset: 0x0008B904
		// (set) Token: 0x060021BC RID: 8636 RVA: 0x000119D8 File Offset: 0x0000FBD8
		public unsafe static Func<Command, bool> _2___commandPredicate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGMatchMessageConsumer.__O.NativeFieldInfoPtr__2___commandPredicate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGMatchMessageConsumer.__O.NativeFieldInfoPtr__2___commandPredicate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeFieldInfoPtr__0___animationShouldIgnore;

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeFieldInfoPtr__1___messagePredicate;

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeFieldInfoPtr__2___commandPredicate;
	}

	// Token: 0x020002CF RID: 719
	[ObfuscatedName("DBGMatchMessageConsumer+<Start>d__12")]
	public sealed class _Start_d__12 : global::Il2CppSystem.Object
	{
		// Token: 0x060021BD RID: 8637 RVA: 0x0008D72C File Offset: 0x0008B92C
		// Note: this type is marked as 'beforefieldinit'.
		static _Start_d__12()
		{
			Il2CppClassPointerStore<DBGMatchMessageConsumer._Start_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGMatchMessageConsumer>.NativeClassPtr, "<Start>d__12");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGMatchMessageConsumer._Start_d__12>.NativeClassPtr);
			DBGMatchMessageConsumer._Start_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchMessageConsumer._Start_d__12>.NativeClassPtr, "<>1__state");
			DBGMatchMessageConsumer._Start_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchMessageConsumer._Start_d__12>.NativeClassPtr, "<>2__current");
			DBGMatchMessageConsumer._Start_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchMessageConsumer._Start_d__12>.NativeClassPtr, "<>4__this");
			DBGMatchMessageConsumer._Start_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageConsumer._Start_d__12>.NativeClassPtr, 100663437);
			DBGMatchMessageConsumer._Start_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageConsumer._Start_d__12>.NativeClassPtr, 100663438);
			DBGMatchMessageConsumer._Start_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageConsumer._Start_d__12>.NativeClassPtr, 100663439);
			DBGMatchMessageConsumer._Start_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageConsumer._Start_d__12>.NativeClassPtr, 100663440);
			DBGMatchMessageConsumer._Start_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageConsumer._Start_d__12>.NativeClassPtr, 100663441);
			DBGMatchMessageConsumer._Start_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageConsumer._Start_d__12>.NativeClassPtr, 100663442);
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x0008D80C File Offset: 0x0008BA0C
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Start_d__12(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGMatchMessageConsumer._Start_d__12>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchMessageConsumer._Start_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x0008D854 File Offset: 0x0008BA54
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchMessageConsumer._Start_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x0008D888 File Offset: 0x0008BA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495876, XrefRangeEnd = 495891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchMessageConsumer._Start_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x060021C1 RID: 8641 RVA: 0x0008D8C4 File Offset: 0x0008BAC4
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchMessageConsumer._Start_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x0008D904 File Offset: 0x0008BB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495891, XrefRangeEnd = 495896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchMessageConsumer._Start_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x060021C3 RID: 8643 RVA: 0x0008D938 File Offset: 0x0008BB38
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchMessageConsumer._Start_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x000119EA File Offset: 0x0000FBEA
		public _Start_d__12(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x060021C5 RID: 8645 RVA: 0x0008D978 File Offset: 0x0008BB78
		// (set) Token: 0x060021C6 RID: 8646 RVA: 0x000119F3 File Offset: 0x0000FBF3
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageConsumer._Start_d__12.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageConsumer._Start_d__12.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x060021C7 RID: 8647 RVA: 0x0008D9A0 File Offset: 0x0008BBA0
		// (set) Token: 0x060021C8 RID: 8648 RVA: 0x00011A0E File Offset: 0x0000FC0E
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageConsumer._Start_d__12.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageConsumer._Start_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x060021C9 RID: 8649 RVA: 0x0008D9D0 File Offset: 0x0008BBD0
		// (set) Token: 0x060021CA RID: 8650 RVA: 0x00011A2D File Offset: 0x0000FC2D
		public unsafe DBGMatchMessageConsumer __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageConsumer._Start_d__12.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGMatchMessageConsumer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageConsumer._Start_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400153E RID: 5438
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400153F RID: 5439
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001540 RID: 5440
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001541 RID: 5441
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001542 RID: 5442
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001543 RID: 5443
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001544 RID: 5444
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
