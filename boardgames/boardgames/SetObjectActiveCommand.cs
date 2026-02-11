using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

// Token: 0x02000012 RID: 18
public class SetObjectActiveCommand : Command
{
	// Token: 0x060000A4 RID: 164 RVA: 0x00012BCC File Offset: 0x00010DCC
	// Note: this type is marked as 'beforefieldinit'.
	static SetObjectActiveCommand()
	{
		Il2CppClassPointerStore<SetObjectActiveCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "SetObjectActiveCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetObjectActiveCommand>.NativeClassPtr);
		SetObjectActiveCommand.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetObjectActiveCommand>.NativeClassPtr, "message");
		SetObjectActiveCommand.NativeMethodInfoPtr__ctor_Public_Void_SetObjectActive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjectActiveCommand>.NativeClassPtr, 100663427);
		SetObjectActiveCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjectActiveCommand>.NativeClassPtr, 100663428);
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00012C38 File Offset: 0x00010E38
	[CallerCount(37)]
	[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SetObjectActiveCommand(SetObjectActive message)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetObjectActiveCommand>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjectActiveCommand.NativeMethodInfoPtr__ctor_Public_Void_SetObjectActive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00012C84 File Offset: 0x00010E84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982799, XrefRangeEnd = 982804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IEnumerator execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetObjectActiveCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x000023EA File Offset: 0x000005EA
	public SetObjectActiveCommand(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x060000A8 RID: 168 RVA: 0x00012CD0 File Offset: 0x00010ED0
	// (set) Token: 0x060000A9 RID: 169 RVA: 0x000023F3 File Offset: 0x000005F3
	public unsafe SetObjectActive message
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjectActiveCommand.NativeFieldInfoPtr_message);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetObjectActive>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjectActiveCommand.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000074 RID: 116
	private static readonly IntPtr NativeFieldInfoPtr_message;

	// Token: 0x04000075 RID: 117
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SetObjectActive_0;

	// Token: 0x04000076 RID: 118
	private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

	// Token: 0x02000195 RID: 405
	[ObfuscatedName("SetObjectActiveCommand+<execute>d__2")]
	public sealed class _execute_d__2 : Object
	{
		// Token: 0x060013B8 RID: 5048 RVA: 0x0004DFBC File Offset: 0x0004C1BC
		// Note: this type is marked as 'beforefieldinit'.
		static _execute_d__2()
		{
			Il2CppClassPointerStore<SetObjectActiveCommand._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetObjectActiveCommand>.NativeClassPtr, "<execute>d__2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetObjectActiveCommand._execute_d__2>.NativeClassPtr);
			SetObjectActiveCommand._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetObjectActiveCommand._execute_d__2>.NativeClassPtr, "<>1__state");
			SetObjectActiveCommand._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetObjectActiveCommand._execute_d__2>.NativeClassPtr, "<>2__current");
			SetObjectActiveCommand._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetObjectActiveCommand._execute_d__2>.NativeClassPtr, "<>4__this");
			SetObjectActiveCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjectActiveCommand._execute_d__2>.NativeClassPtr, 100663429);
			SetObjectActiveCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjectActiveCommand._execute_d__2>.NativeClassPtr, 100663430);
			SetObjectActiveCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjectActiveCommand._execute_d__2>.NativeClassPtr, 100663431);
			SetObjectActiveCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjectActiveCommand._execute_d__2>.NativeClassPtr, 100663432);
			SetObjectActiveCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjectActiveCommand._execute_d__2>.NativeClassPtr, 100663433);
			SetObjectActiveCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetObjectActiveCommand._execute_d__2>.NativeClassPtr, 100663434);
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x0004E09C File Offset: 0x0004C29C
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _execute_d__2(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetObjectActiveCommand._execute_d__2>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjectActiveCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x0004E0E4 File Offset: 0x0004C2E4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjectActiveCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x0004E118 File Offset: 0x0004C318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982790, XrefRangeEnd = 982794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjectActiveCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x0004E154 File Offset: 0x0004C354
		public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjectActiveCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x0004E194 File Offset: 0x0004C394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982794, XrefRangeEnd = 982799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjectActiveCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x0004E1C8 File Offset: 0x0004C3C8
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetObjectActiveCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x0000B31E File Offset: 0x0000951E
		public _execute_d__2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x0004E208 File Offset: 0x0004C408
		// (set) Token: 0x060013C1 RID: 5057 RVA: 0x0000B327 File Offset: 0x00009527
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjectActiveCommand._execute_d__2.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjectActiveCommand._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x0004E230 File Offset: 0x0004C430
		// (set) Token: 0x060013C3 RID: 5059 RVA: 0x0000B342 File Offset: 0x00009542
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjectActiveCommand._execute_d__2.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjectActiveCommand._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x0004E260 File Offset: 0x0004C460
		// (set) Token: 0x060013C5 RID: 5061 RVA: 0x0000B361 File Offset: 0x00009561
		public unsafe SetObjectActiveCommand __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjectActiveCommand._execute_d__2.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetObjectActiveCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetObjectActiveCommand._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BF9 RID: 3065
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04000BFA RID: 3066
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
