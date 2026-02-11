using System;
using dwd.core;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.data.commands
{
	// Token: 0x02000147 RID: 327
	public class DeleteLocalDataCommand : Command
	{
		// Token: 0x060010BC RID: 4284 RVA: 0x000447A4 File Offset: 0x000429A4
		// Note: this type is marked as 'beforefieldinit'.
		static DeleteLocalDataCommand()
		{
			Il2CppClassPointerStore<DeleteLocalDataCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.data.commands", "DeleteLocalDataCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteLocalDataCommand>.NativeClassPtr);
			DeleteLocalDataCommand.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteLocalDataCommand>.NativeClassPtr, "path");
			DeleteLocalDataCommand.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteLocalDataCommand>.NativeClassPtr, "status");
			DeleteLocalDataCommand.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteLocalDataCommand>.NativeClassPtr, 100665736);
			DeleteLocalDataCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteLocalDataCommand>.NativeClassPtr, 100665737);
			DeleteLocalDataCommand.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteLocalDataCommand>.NativeClassPtr, 100665738);
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00044838 File Offset: 0x00042A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999438, XrefRangeEnd = 999445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeleteLocalDataCommand(string path)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeleteLocalDataCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteLocalDataCommand.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x00044884 File Offset: 0x00042A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999445, XrefRangeEnd = 999450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteLocalDataCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x000448D0 File Offset: 0x00042AD0
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteLocalDataCommand.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00009C34 File Offset: 0x00007E34
		public DeleteLocalDataCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060010C1 RID: 4289 RVA: 0x00044908 File Offset: 0x00042B08
		// (set) Token: 0x060010C2 RID: 4290 RVA: 0x00009C3D File Offset: 0x00007E3D
		public unsafe string path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteLocalDataCommand.NativeFieldInfoPtr_path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteLocalDataCommand.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x00044930 File Offset: 0x00042B30
		// (set) Token: 0x060010C4 RID: 4292 RVA: 0x00009C5C File Offset: 0x00007E5C
		public ErrorInfo status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteLocalDataCommand.NativeFieldInfoPtr_status);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteLocalDataCommand.NativeFieldInfoPtr_status), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x02000272 RID: 626
		[ObfuscatedName("boardgames.data.commands.DeleteLocalDataCommand+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06001CD2 RID: 7378 RVA: 0x00069FF0 File Offset: 0x000681F0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<DeleteLocalDataCommand._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeleteLocalDataCommand>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteLocalDataCommand._execute_d__3>.NativeClassPtr);
				DeleteLocalDataCommand._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteLocalDataCommand._execute_d__3>.NativeClassPtr, "<>1__state");
				DeleteLocalDataCommand._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteLocalDataCommand._execute_d__3>.NativeClassPtr, "<>2__current");
				DeleteLocalDataCommand._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteLocalDataCommand._execute_d__3>.NativeClassPtr, "<>4__this");
				DeleteLocalDataCommand._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteLocalDataCommand._execute_d__3>.NativeClassPtr, 100665739);
				DeleteLocalDataCommand._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteLocalDataCommand._execute_d__3>.NativeClassPtr, 100665740);
				DeleteLocalDataCommand._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteLocalDataCommand._execute_d__3>.NativeClassPtr, 100665741);
				DeleteLocalDataCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteLocalDataCommand._execute_d__3>.NativeClassPtr, 100665742);
				DeleteLocalDataCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteLocalDataCommand._execute_d__3>.NativeClassPtr, 100665743);
				DeleteLocalDataCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteLocalDataCommand._execute_d__3>.NativeClassPtr, 100665744);
			}

			// Token: 0x06001CD3 RID: 7379 RVA: 0x0006A0D0 File Offset: 0x000682D0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeleteLocalDataCommand._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteLocalDataCommand._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001CD4 RID: 7380 RVA: 0x0006A118 File Offset: 0x00068318
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteLocalDataCommand._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CD5 RID: 7381 RVA: 0x0006A14C File Offset: 0x0006834C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999428, XrefRangeEnd = 999433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteLocalDataCommand._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000891 RID: 2193
			// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x0006A188 File Offset: 0x00068388
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteLocalDataCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001CD7 RID: 7383 RVA: 0x0006A1C8 File Offset: 0x000683C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999433, XrefRangeEnd = 999438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteLocalDataCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000892 RID: 2194
			// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x0006A1FC File Offset: 0x000683FC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteLocalDataCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001CD9 RID: 7385 RVA: 0x0000F83E File Offset: 0x0000DA3E
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700088E RID: 2190
			// (get) Token: 0x06001CDA RID: 7386 RVA: 0x0006A23C File Offset: 0x0006843C
			// (set) Token: 0x06001CDB RID: 7387 RVA: 0x0000F847 File Offset: 0x0000DA47
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteLocalDataCommand._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteLocalDataCommand._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700088F RID: 2191
			// (get) Token: 0x06001CDC RID: 7388 RVA: 0x0006A264 File Offset: 0x00068464
			// (set) Token: 0x06001CDD RID: 7389 RVA: 0x0000F862 File Offset: 0x0000DA62
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteLocalDataCommand._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteLocalDataCommand._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000890 RID: 2192
			// (get) Token: 0x06001CDE RID: 7390 RVA: 0x0006A294 File Offset: 0x00068494
			// (set) Token: 0x06001CDF RID: 7391 RVA: 0x0000F881 File Offset: 0x0000DA81
			public unsafe DeleteLocalDataCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteLocalDataCommand._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeleteLocalDataCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteLocalDataCommand._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001189 RID: 4489
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400118A RID: 4490
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400118B RID: 4491
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400118C RID: 4492
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400118D RID: 4493
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400118E RID: 4494
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400118F RID: 4495
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001190 RID: 4496
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001191 RID: 4497
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
