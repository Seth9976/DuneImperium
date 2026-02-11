using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;

namespace dbgclient
{
	// Token: 0x02000082 RID: 130
	public class UpdateObjectivesSequence : VoodooGenericSequence
	{
		// Token: 0x0600050C RID: 1292 RVA: 0x0002D464 File Offset: 0x0002B664
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateObjectivesSequence()
		{
			Il2CppClassPointerStore<UpdateObjectivesSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient", "UpdateObjectivesSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateObjectivesSequence>.NativeClassPtr);
			UpdateObjectivesSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateObjectivesSequence>.NativeClassPtr, 100664048);
			UpdateObjectivesSequence.NativeMethodInfoPtr_runAnimationCommands_Protected_Virtual_IEnumerator_List_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateObjectivesSequence>.NativeClassPtr, 100664049);
			UpdateObjectivesSequence.NativeMethodInfoPtr___n__0_Private_IEnumerator_List_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateObjectivesSequence>.NativeClassPtr, 100664050);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0002D4D0 File Offset: 0x0002B6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501371, XrefRangeEnd = 501372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateObjectivesSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateObjectivesSequence>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateObjectivesSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0002D540 File Offset: 0x0002B740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501372, XrefRangeEnd = 501378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator runAnimationCommands(List<Command> animationCommands)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animationCommands);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateObjectivesSequence.NativeMethodInfoPtr_runAnimationCommands_Protected_Virtual_IEnumerator_List_1_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0002D59C File Offset: 0x0002B79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501378, XrefRangeEnd = 501379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator __n__0(List<Command> animationCommands)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animationCommands);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateObjectivesSequence.NativeMethodInfoPtr___n__0_Private_IEnumerator_List_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000044DE File Offset: 0x000026DE
		public UpdateObjectivesSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_runAnimationCommands_Protected_Virtual_IEnumerator_List_1_Command_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_List_1_Command_0;

		// Token: 0x020002FD RID: 765
		[ObfuscatedName("dbgclient.UpdateObjectivesSequence+<runAnimationCommands>d__1")]
		public sealed class _runAnimationCommands_d__1 : Object
		{
			// Token: 0x06002405 RID: 9221 RVA: 0x00094320 File Offset: 0x00092520
			// Note: this type is marked as 'beforefieldinit'.
			static _runAnimationCommands_d__1()
			{
				Il2CppClassPointerStore<UpdateObjectivesSequence._runAnimationCommands_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateObjectivesSequence>.NativeClassPtr, "<runAnimationCommands>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateObjectivesSequence._runAnimationCommands_d__1>.NativeClassPtr);
				UpdateObjectivesSequence._runAnimationCommands_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateObjectivesSequence._runAnimationCommands_d__1>.NativeClassPtr, "<>1__state");
				UpdateObjectivesSequence._runAnimationCommands_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateObjectivesSequence._runAnimationCommands_d__1>.NativeClassPtr, "<>2__current");
				UpdateObjectivesSequence._runAnimationCommands_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateObjectivesSequence._runAnimationCommands_d__1>.NativeClassPtr, "<>4__this");
				UpdateObjectivesSequence._runAnimationCommands_d__1.NativeFieldInfoPtr_animationCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateObjectivesSequence._runAnimationCommands_d__1>.NativeClassPtr, "animationCommands");
				UpdateObjectivesSequence._runAnimationCommands_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateObjectivesSequence._runAnimationCommands_d__1>.NativeClassPtr, 100664051);
				UpdateObjectivesSequence._runAnimationCommands_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateObjectivesSequence._runAnimationCommands_d__1>.NativeClassPtr, 100664052);
				UpdateObjectivesSequence._runAnimationCommands_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateObjectivesSequence._runAnimationCommands_d__1>.NativeClassPtr, 100664053);
				UpdateObjectivesSequence._runAnimationCommands_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateObjectivesSequence._runAnimationCommands_d__1>.NativeClassPtr, 100664054);
				UpdateObjectivesSequence._runAnimationCommands_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateObjectivesSequence._runAnimationCommands_d__1>.NativeClassPtr, 100664055);
				UpdateObjectivesSequence._runAnimationCommands_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateObjectivesSequence._runAnimationCommands_d__1>.NativeClassPtr, 100664056);
			}

			// Token: 0x06002406 RID: 9222 RVA: 0x00094414 File Offset: 0x00092614
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _runAnimationCommands_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateObjectivesSequence._runAnimationCommands_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateObjectivesSequence._runAnimationCommands_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002407 RID: 9223 RVA: 0x0009445C File Offset: 0x0009265C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateObjectivesSequence._runAnimationCommands_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002408 RID: 9224 RVA: 0x00094490 File Offset: 0x00092690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501342, XrefRangeEnd = 501366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateObjectivesSequence._runAnimationCommands_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170009D2 RID: 2514
			// (get) Token: 0x06002409 RID: 9225 RVA: 0x000944CC File Offset: 0x000926CC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateObjectivesSequence._runAnimationCommands_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600240A RID: 9226 RVA: 0x0009450C File Offset: 0x0009270C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501366, XrefRangeEnd = 501371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateObjectivesSequence._runAnimationCommands_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009D3 RID: 2515
			// (get) Token: 0x0600240B RID: 9227 RVA: 0x00094540 File Offset: 0x00092740
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateObjectivesSequence._runAnimationCommands_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600240C RID: 9228 RVA: 0x00012BDB File Offset: 0x00010DDB
			public _runAnimationCommands_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009CE RID: 2510
			// (get) Token: 0x0600240D RID: 9229 RVA: 0x00094580 File Offset: 0x00092780
			// (set) Token: 0x0600240E RID: 9230 RVA: 0x00012BE4 File Offset: 0x00010DE4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateObjectivesSequence._runAnimationCommands_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateObjectivesSequence._runAnimationCommands_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009CF RID: 2511
			// (get) Token: 0x0600240F RID: 9231 RVA: 0x000945A8 File Offset: 0x000927A8
			// (set) Token: 0x06002410 RID: 9232 RVA: 0x00012BFF File Offset: 0x00010DFF
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateObjectivesSequence._runAnimationCommands_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateObjectivesSequence._runAnimationCommands_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009D0 RID: 2512
			// (get) Token: 0x06002411 RID: 9233 RVA: 0x000945D8 File Offset: 0x000927D8
			// (set) Token: 0x06002412 RID: 9234 RVA: 0x00012C1E File Offset: 0x00010E1E
			public unsafe UpdateObjectivesSequence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateObjectivesSequence._runAnimationCommands_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateObjectivesSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateObjectivesSequence._runAnimationCommands_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009D1 RID: 2513
			// (get) Token: 0x06002413 RID: 9235 RVA: 0x00094608 File Offset: 0x00092808
			// (set) Token: 0x06002414 RID: 9236 RVA: 0x00012C3D File Offset: 0x00010E3D
			public unsafe List<Command> animationCommands
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateObjectivesSequence._runAnimationCommands_d__1.NativeFieldInfoPtr_animationCommands);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Command>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateObjectivesSequence._runAnimationCommands_d__1.NativeFieldInfoPtr_animationCommands), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016A2 RID: 5794
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016A3 RID: 5795
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016A4 RID: 5796
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040016A5 RID: 5797
			private static readonly IntPtr NativeFieldInfoPtr_animationCommands;

			// Token: 0x040016A6 RID: 5798
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016A7 RID: 5799
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016A8 RID: 5800
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016A9 RID: 5801
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040016AA RID: 5802
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016AB RID: 5803
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
