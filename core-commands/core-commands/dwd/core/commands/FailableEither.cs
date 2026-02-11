using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.commands
{
	// Token: 0x0200002A RID: 42
	public class FailableEither : Command
	{
		// Token: 0x060001A1 RID: 417 RVA: 0x0000B42C File Offset: 0x0000962C
		// Note: this type is marked as 'beforefieldinit'.
		static FailableEither()
		{
			Il2CppClassPointerStore<FailableEither>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.commands", "FailableEither");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FailableEither>.NativeClassPtr);
			FailableEither.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FailableEither>.NativeClassPtr, "command");
			FailableEither.NativeFieldInfoPtr_falseCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FailableEither>.NativeClassPtr, "falseCommand");
			FailableEither.NativeFieldInfoPtr_trueCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FailableEither>.NativeClassPtr, "trueCommand");
			FailableEither.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FailableEither>.NativeClassPtr, "status");
			FailableEither.NativeMethodInfoPtr__ctor_Public_Void_IFailable_Func_1_IFailable_Func_1_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailableEither>.NativeClassPtr, 100663759);
			FailableEither.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailableEither>.NativeClassPtr, 100663760);
			FailableEither.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailableEither>.NativeClassPtr, 100663761);
			FailableEither.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailableEither>.NativeClassPtr, 100663762);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000B4FC File Offset: 0x000096FC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1209473, RefRangeEnd = 1209485, XrefRangeStart = 1209465, XrefRangeEnd = 1209473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FailableEither(IFailable command, Func<IFailable> trueCommand, Func<IFailable> falseCommand)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FailableEither>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trueCommand);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(falseCommand);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FailableEither.NativeMethodInfoPtr__ctor_Public_Void_IFailable_Func_1_IFailable_Func_1_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000B56C File Offset: 0x0000976C
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FailableEither.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000B5A4 File Offset: 0x000097A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209485, XrefRangeEnd = 1209490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FailableEither.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000B5F0 File Offset: 0x000097F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209490, XrefRangeEnd = 1209493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FailableEither.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002AA7 File Offset: 0x00000CA7
		public FailableEither(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000B634 File Offset: 0x00009834
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00002AB0 File Offset: 0x00000CB0
		public unsafe IFailable command
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailableEither.NativeFieldInfoPtr_command);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailableEither.NativeFieldInfoPtr_command), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000B664 File Offset: 0x00009864
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00002ACF File Offset: 0x00000CCF
		public unsafe Func<IFailable> falseCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailableEither.NativeFieldInfoPtr_falseCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IFailable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailableEither.NativeFieldInfoPtr_falseCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000B694 File Offset: 0x00009894
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00002AEE File Offset: 0x00000CEE
		public unsafe Func<IFailable> trueCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailableEither.NativeFieldInfoPtr_trueCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IFailable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailableEither.NativeFieldInfoPtr_trueCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0000B6C4 File Offset: 0x000098C4
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00002B0D File Offset: 0x00000D0D
		public ErrorInfo status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailableEither.NativeFieldInfoPtr_status);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailableEither.NativeFieldInfoPtr_status), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr_command;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr_falseCommand;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr_trueCommand;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IFailable_Func_1_IFailable_Func_1_IFailable_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0200008C RID: 140
		[ObfuscatedName("dwd.core.commands.FailableEither+<execute>d__6")]
		public sealed class _execute_d__6 : Object
		{
			// Token: 0x0600051E RID: 1310 RVA: 0x00016DDC File Offset: 0x00014FDC
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__6()
			{
				Il2CppClassPointerStore<FailableEither._execute_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FailableEither>.NativeClassPtr, "<execute>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FailableEither._execute_d__6>.NativeClassPtr);
				FailableEither._execute_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FailableEither._execute_d__6>.NativeClassPtr, "<>1__state");
				FailableEither._execute_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FailableEither._execute_d__6>.NativeClassPtr, "<>2__current");
				FailableEither._execute_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FailableEither._execute_d__6>.NativeClassPtr, "<>4__this");
				FailableEither._execute_d__6.NativeFieldInfoPtr__nextCommand_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FailableEither._execute_d__6>.NativeClassPtr, "<nextCommand>5__2");
				FailableEither._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailableEither._execute_d__6>.NativeClassPtr, 100663763);
				FailableEither._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailableEither._execute_d__6>.NativeClassPtr, 100663764);
				FailableEither._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailableEither._execute_d__6>.NativeClassPtr, 100663765);
				FailableEither._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailableEither._execute_d__6>.NativeClassPtr, 100663766);
				FailableEither._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailableEither._execute_d__6>.NativeClassPtr, 100663767);
				FailableEither._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailableEither._execute_d__6>.NativeClassPtr, 100663768);
			}

			// Token: 0x0600051F RID: 1311 RVA: 0x00016ED0 File Offset: 0x000150D0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FailableEither._execute_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FailableEither._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000520 RID: 1312 RVA: 0x00016F18 File Offset: 0x00015118
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FailableEither._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000521 RID: 1313 RVA: 0x00016F4C File Offset: 0x0001514C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209452, XrefRangeEnd = 1209460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FailableEither._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700015C RID: 348
			// (get) Token: 0x06000522 RID: 1314 RVA: 0x00016F88 File Offset: 0x00015188
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FailableEither._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000523 RID: 1315 RVA: 0x00016FC8 File Offset: 0x000151C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209460, XrefRangeEnd = 1209465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FailableEither._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700015D RID: 349
			// (get) Token: 0x06000524 RID: 1316 RVA: 0x00016FFC File Offset: 0x000151FC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FailableEither._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000525 RID: 1317 RVA: 0x000043F9 File Offset: 0x000025F9
			public _execute_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x06000526 RID: 1318 RVA: 0x0001703C File Offset: 0x0001523C
			// (set) Token: 0x06000527 RID: 1319 RVA: 0x00004402 File Offset: 0x00002602
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailableEither._execute_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailableEither._execute_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x06000528 RID: 1320 RVA: 0x00017064 File Offset: 0x00015264
			// (set) Token: 0x06000529 RID: 1321 RVA: 0x0000441D File Offset: 0x0000261D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailableEither._execute_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailableEither._execute_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700015A RID: 346
			// (get) Token: 0x0600052A RID: 1322 RVA: 0x00017094 File Offset: 0x00015294
			// (set) Token: 0x0600052B RID: 1323 RVA: 0x0000443C File Offset: 0x0000263C
			public unsafe FailableEither __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailableEither._execute_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FailableEither>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailableEither._execute_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700015B RID: 347
			// (get) Token: 0x0600052C RID: 1324 RVA: 0x000170C4 File Offset: 0x000152C4
			// (set) Token: 0x0600052D RID: 1325 RVA: 0x0000445B File Offset: 0x0000265B
			public unsafe IFailable _nextCommand_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailableEither._execute_d__6.NativeFieldInfoPtr__nextCommand_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailableEither._execute_d__6.NativeFieldInfoPtr__nextCommand_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400031E RID: 798
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400031F RID: 799
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000320 RID: 800
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000321 RID: 801
			private static readonly IntPtr NativeFieldInfoPtr__nextCommand_5__2;

			// Token: 0x04000322 RID: 802
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000323 RID: 803
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000324 RID: 804
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000325 RID: 805
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000326 RID: 806
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000327 RID: 807
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
