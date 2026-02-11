using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace lotus
{
	// Token: 0x02000086 RID: 134
	public class VoodooGroupedSequence : VoodooLinearSequence
	{
		// Token: 0x06000811 RID: 2065 RVA: 0x00024270 File Offset: 0x00022470
		// Note: this type is marked as 'beforefieldinit'.
		static VoodooGroupedSequence()
		{
			Il2CppClassPointerStore<VoodooGroupedSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "VoodooGroupedSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooGroupedSequence>.NativeClassPtr);
			VoodooGroupedSequence.NativeFieldInfoPtr_lastGroupCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupedSequence>.NativeClassPtr, "lastGroupCommand");
			VoodooGroupedSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence>.NativeClassPtr, 100664407);
			VoodooGroupedSequence.NativeMethodInfoPtr_CreateGroupCommand_Protected_Virtual_VoodooGroupCommand_Command_GroupInitInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence>.NativeClassPtr, 100664408);
			VoodooGroupedSequence.NativeMethodInfoPtr_PreCommand_Protected_Virtual_IEnumerator_Command_Nullable_1_GroupInitInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence>.NativeClassPtr, 100664409);
			VoodooGroupedSequence.NativeMethodInfoPtr_PostSequence_Protected_Virtual_Final_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence>.NativeClassPtr, 100664410);
			VoodooGroupedSequence.NativeMethodInfoPtr_PostLastGroupCommand_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence>.NativeClassPtr, 100664411);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00024318 File Offset: 0x00022518
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 719643, RefRangeEnd = 719682, XrefRangeStart = 719643, XrefRangeEnd = 719682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooGroupedSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooGroupedSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupedSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00024388 File Offset: 0x00022588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115661, XrefRangeEnd = 1115664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override VoodooGroupCommand CreateGroupCommand(Command command, VoodooGroupCommand.GroupInitInfo groupInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(groupInfo));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooGroupedSequence.NativeMethodInfoPtr_CreateGroupCommand_Protected_Virtual_VoodooGroupCommand_Command_GroupInitInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VoodooGroupCommand>(intPtr3) : null;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x000243FC File Offset: 0x000225FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115664, XrefRangeEnd = 1115671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator PreCommand(Command command, Nullable<VoodooGroupCommand.GroupInitInfo> groupInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(groupInfo));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooGroupedSequence.NativeMethodInfoPtr_PreCommand_Protected_Virtual_IEnumerator_Command_Nullable_1_GroupInitInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00024470 File Offset: 0x00022670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115671, XrefRangeEnd = 1115676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator PostSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupedSequence.NativeMethodInfoPtr_PostSequence_Protected_Virtual_Final_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x000244B0 File Offset: 0x000226B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115676, XrefRangeEnd = 1115680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator PostLastGroupCommand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooGroupedSequence.NativeMethodInfoPtr_PostLastGroupCommand_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00005F65 File Offset: 0x00004165
		public VoodooGroupedSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x000244FC File Offset: 0x000226FC
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x00005F6E File Offset: 0x0000416E
		public unsafe VoodooGroupCommand lastGroupCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence.NativeFieldInfoPtr_lastGroupCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooGroupCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence.NativeFieldInfoPtr_lastGroupCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeFieldInfoPtr_lastGroupCommand;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_CreateGroupCommand_Protected_Virtual_VoodooGroupCommand_Command_GroupInitInfo_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_PreCommand_Protected_Virtual_IEnumerator_Command_Nullable_1_GroupInitInfo_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_PostSequence_Protected_Virtual_Final_IEnumerator_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_PostLastGroupCommand_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x02000103 RID: 259
		[ObfuscatedName("lotus.VoodooGroupedSequence+<PostLastGroupCommand>d__5")]
		public sealed class _PostLastGroupCommand_d__5 : Object
		{
			// Token: 0x06000D56 RID: 3414 RVA: 0x000344E4 File Offset: 0x000326E4
			// Note: this type is marked as 'beforefieldinit'.
			static _PostLastGroupCommand_d__5()
			{
				Il2CppClassPointerStore<VoodooGroupedSequence._PostLastGroupCommand_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooGroupedSequence>.NativeClassPtr, "<PostLastGroupCommand>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooGroupedSequence._PostLastGroupCommand_d__5>.NativeClassPtr);
				VoodooGroupedSequence._PostLastGroupCommand_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupedSequence._PostLastGroupCommand_d__5>.NativeClassPtr, "<>1__state");
				VoodooGroupedSequence._PostLastGroupCommand_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupedSequence._PostLastGroupCommand_d__5>.NativeClassPtr, "<>2__current");
				VoodooGroupedSequence._PostLastGroupCommand_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence._PostLastGroupCommand_d__5>.NativeClassPtr, 100664412);
				VoodooGroupedSequence._PostLastGroupCommand_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence._PostLastGroupCommand_d__5>.NativeClassPtr, 100664413);
				VoodooGroupedSequence._PostLastGroupCommand_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence._PostLastGroupCommand_d__5>.NativeClassPtr, 100664414);
				VoodooGroupedSequence._PostLastGroupCommand_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence._PostLastGroupCommand_d__5>.NativeClassPtr, 100664415);
				VoodooGroupedSequence._PostLastGroupCommand_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence._PostLastGroupCommand_d__5>.NativeClassPtr, 100664416);
				VoodooGroupedSequence._PostLastGroupCommand_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence._PostLastGroupCommand_d__5>.NativeClassPtr, 100664417);
			}

			// Token: 0x06000D57 RID: 3415 RVA: 0x000345B0 File Offset: 0x000327B0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PostLastGroupCommand_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooGroupedSequence._PostLastGroupCommand_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupedSequence._PostLastGroupCommand_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D58 RID: 3416 RVA: 0x000345F8 File Offset: 0x000327F8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupedSequence._PostLastGroupCommand_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D59 RID: 3417 RVA: 0x0003462C File Offset: 0x0003282C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupedSequence._PostLastGroupCommand_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170003FA RID: 1018
			// (get) Token: 0x06000D5A RID: 3418 RVA: 0x00034668 File Offset: 0x00032868
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupedSequence._PostLastGroupCommand_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000D5B RID: 3419 RVA: 0x000346A8 File Offset: 0x000328A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115633, XrefRangeEnd = 1115638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupedSequence._PostLastGroupCommand_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003FB RID: 1019
			// (get) Token: 0x06000D5C RID: 3420 RVA: 0x000346DC File Offset: 0x000328DC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupedSequence._PostLastGroupCommand_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000D5D RID: 3421 RVA: 0x00008A06 File Offset: 0x00006C06
			public _PostLastGroupCommand_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003F8 RID: 1016
			// (get) Token: 0x06000D5E RID: 3422 RVA: 0x0003471C File Offset: 0x0003291C
			// (set) Token: 0x06000D5F RID: 3423 RVA: 0x00008A0F File Offset: 0x00006C0F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PostLastGroupCommand_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PostLastGroupCommand_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003F9 RID: 1017
			// (get) Token: 0x06000D60 RID: 3424 RVA: 0x00034744 File Offset: 0x00032944
			// (set) Token: 0x06000D61 RID: 3425 RVA: 0x00008A2A File Offset: 0x00006C2A
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PostLastGroupCommand_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PostLastGroupCommand_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000846 RID: 2118
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000847 RID: 2119
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000848 RID: 2120
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000849 RID: 2121
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400084A RID: 2122
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400084B RID: 2123
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400084C RID: 2124
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400084D RID: 2125
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000104 RID: 260
		[ObfuscatedName("lotus.VoodooGroupedSequence+<PostSequence>d__4")]
		public sealed class _PostSequence_d__4 : Object
		{
			// Token: 0x06000D62 RID: 3426 RVA: 0x00034774 File Offset: 0x00032974
			// Note: this type is marked as 'beforefieldinit'.
			static _PostSequence_d__4()
			{
				Il2CppClassPointerStore<VoodooGroupedSequence._PostSequence_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooGroupedSequence>.NativeClassPtr, "<PostSequence>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooGroupedSequence._PostSequence_d__4>.NativeClassPtr);
				VoodooGroupedSequence._PostSequence_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupedSequence._PostSequence_d__4>.NativeClassPtr, "<>1__state");
				VoodooGroupedSequence._PostSequence_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupedSequence._PostSequence_d__4>.NativeClassPtr, "<>2__current");
				VoodooGroupedSequence._PostSequence_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupedSequence._PostSequence_d__4>.NativeClassPtr, "<>4__this");
				VoodooGroupedSequence._PostSequence_d__4.NativeFieldInfoPtr__postLastGroupCommand_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupedSequence._PostSequence_d__4>.NativeClassPtr, "<postLastGroupCommand>5__2");
				VoodooGroupedSequence._PostSequence_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence._PostSequence_d__4>.NativeClassPtr, 100664418);
				VoodooGroupedSequence._PostSequence_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence._PostSequence_d__4>.NativeClassPtr, 100664419);
				VoodooGroupedSequence._PostSequence_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence._PostSequence_d__4>.NativeClassPtr, 100664420);
				VoodooGroupedSequence._PostSequence_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence._PostSequence_d__4>.NativeClassPtr, 100664421);
				VoodooGroupedSequence._PostSequence_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence._PostSequence_d__4>.NativeClassPtr, 100664422);
				VoodooGroupedSequence._PostSequence_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence._PostSequence_d__4>.NativeClassPtr, 100664423);
			}

			// Token: 0x06000D63 RID: 3427 RVA: 0x00034868 File Offset: 0x00032A68
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PostSequence_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooGroupedSequence._PostSequence_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupedSequence._PostSequence_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D64 RID: 3428 RVA: 0x000348B0 File Offset: 0x00032AB0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupedSequence._PostSequence_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D65 RID: 3429 RVA: 0x000348E4 File Offset: 0x00032AE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115638, XrefRangeEnd = 1115639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupedSequence._PostSequence_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000400 RID: 1024
			// (get) Token: 0x06000D66 RID: 3430 RVA: 0x00034920 File Offset: 0x00032B20
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupedSequence._PostSequence_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000D67 RID: 3431 RVA: 0x00034960 File Offset: 0x00032B60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115639, XrefRangeEnd = 1115644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupedSequence._PostSequence_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000401 RID: 1025
			// (get) Token: 0x06000D68 RID: 3432 RVA: 0x00034994 File Offset: 0x00032B94
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupedSequence._PostSequence_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000D69 RID: 3433 RVA: 0x00008A49 File Offset: 0x00006C49
			public _PostSequence_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003FC RID: 1020
			// (get) Token: 0x06000D6A RID: 3434 RVA: 0x000349D4 File Offset: 0x00032BD4
			// (set) Token: 0x06000D6B RID: 3435 RVA: 0x00008A52 File Offset: 0x00006C52
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PostSequence_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PostSequence_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003FD RID: 1021
			// (get) Token: 0x06000D6C RID: 3436 RVA: 0x000349FC File Offset: 0x00032BFC
			// (set) Token: 0x06000D6D RID: 3437 RVA: 0x00008A6D File Offset: 0x00006C6D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PostSequence_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PostSequence_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003FE RID: 1022
			// (get) Token: 0x06000D6E RID: 3438 RVA: 0x00034A2C File Offset: 0x00032C2C
			// (set) Token: 0x06000D6F RID: 3439 RVA: 0x00008A8C File Offset: 0x00006C8C
			public unsafe VoodooGroupedSequence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PostSequence_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooGroupedSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PostSequence_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003FF RID: 1023
			// (get) Token: 0x06000D70 RID: 3440 RVA: 0x00034A5C File Offset: 0x00032C5C
			// (set) Token: 0x06000D71 RID: 3441 RVA: 0x00008AAB File Offset: 0x00006CAB
			public unsafe IEnumerator _postLastGroupCommand_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PostSequence_d__4.NativeFieldInfoPtr__postLastGroupCommand_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PostSequence_d__4.NativeFieldInfoPtr__postLastGroupCommand_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400084E RID: 2126
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400084F RID: 2127
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000850 RID: 2128
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000851 RID: 2129
			private static readonly IntPtr NativeFieldInfoPtr__postLastGroupCommand_5__2;

			// Token: 0x04000852 RID: 2130
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000853 RID: 2131
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000854 RID: 2132
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000855 RID: 2133
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000856 RID: 2134
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000857 RID: 2135
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000105 RID: 261
		[ObfuscatedName("lotus.VoodooGroupedSequence+<PreCommand>d__3")]
		public sealed class _PreCommand_d__3 : Object
		{
			// Token: 0x06000D72 RID: 3442 RVA: 0x00034A8C File Offset: 0x00032C8C
			// Note: this type is marked as 'beforefieldinit'.
			static _PreCommand_d__3()
			{
				Il2CppClassPointerStore<VoodooGroupedSequence._PreCommand_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooGroupedSequence>.NativeClassPtr, "<PreCommand>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooGroupedSequence._PreCommand_d__3>.NativeClassPtr);
				VoodooGroupedSequence._PreCommand_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupedSequence._PreCommand_d__3>.NativeClassPtr, "<>1__state");
				VoodooGroupedSequence._PreCommand_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupedSequence._PreCommand_d__3>.NativeClassPtr, "<>2__current");
				VoodooGroupedSequence._PreCommand_d__3.NativeFieldInfoPtr_groupInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupedSequence._PreCommand_d__3>.NativeClassPtr, "groupInfo");
				VoodooGroupedSequence._PreCommand_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupedSequence._PreCommand_d__3>.NativeClassPtr, "<>4__this");
				VoodooGroupedSequence._PreCommand_d__3.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupedSequence._PreCommand_d__3>.NativeClassPtr, "command");
				VoodooGroupedSequence._PreCommand_d__3.NativeFieldInfoPtr__groupCommand_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupedSequence._PreCommand_d__3>.NativeClassPtr, "<groupCommand>5__2");
				VoodooGroupedSequence._PreCommand_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence._PreCommand_d__3>.NativeClassPtr, 100664424);
				VoodooGroupedSequence._PreCommand_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence._PreCommand_d__3>.NativeClassPtr, 100664425);
				VoodooGroupedSequence._PreCommand_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence._PreCommand_d__3>.NativeClassPtr, 100664426);
				VoodooGroupedSequence._PreCommand_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence._PreCommand_d__3>.NativeClassPtr, 100664427);
				VoodooGroupedSequence._PreCommand_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence._PreCommand_d__3>.NativeClassPtr, 100664428);
				VoodooGroupedSequence._PreCommand_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupedSequence._PreCommand_d__3>.NativeClassPtr, 100664429);
			}

			// Token: 0x06000D73 RID: 3443 RVA: 0x00034BA8 File Offset: 0x00032DA8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PreCommand_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooGroupedSequence._PreCommand_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupedSequence._PreCommand_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D74 RID: 3444 RVA: 0x00034BF0 File Offset: 0x00032DF0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupedSequence._PreCommand_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D75 RID: 3445 RVA: 0x00034C24 File Offset: 0x00032E24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115644, XrefRangeEnd = 1115656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupedSequence._PreCommand_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000408 RID: 1032
			// (get) Token: 0x06000D76 RID: 3446 RVA: 0x00034C60 File Offset: 0x00032E60
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupedSequence._PreCommand_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000D77 RID: 3447 RVA: 0x00034CA0 File Offset: 0x00032EA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115656, XrefRangeEnd = 1115661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupedSequence._PreCommand_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000409 RID: 1033
			// (get) Token: 0x06000D78 RID: 3448 RVA: 0x00034CD4 File Offset: 0x00032ED4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupedSequence._PreCommand_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000D79 RID: 3449 RVA: 0x00008ACA File Offset: 0x00006CCA
			public _PreCommand_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000402 RID: 1026
			// (get) Token: 0x06000D7A RID: 3450 RVA: 0x00034D14 File Offset: 0x00032F14
			// (set) Token: 0x06000D7B RID: 3451 RVA: 0x00008AD3 File Offset: 0x00006CD3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PreCommand_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PreCommand_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000403 RID: 1027
			// (get) Token: 0x06000D7C RID: 3452 RVA: 0x00034D3C File Offset: 0x00032F3C
			// (set) Token: 0x06000D7D RID: 3453 RVA: 0x00008AEE File Offset: 0x00006CEE
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PreCommand_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PreCommand_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000404 RID: 1028
			// (get) Token: 0x06000D7E RID: 3454 RVA: 0x00034D6C File Offset: 0x00032F6C
			// (set) Token: 0x06000D7F RID: 3455 RVA: 0x00008B0D File Offset: 0x00006D0D
			public Nullable<VoodooGroupCommand.GroupInitInfo> groupInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PreCommand_d__3.NativeFieldInfoPtr_groupInfo);
					return new Nullable<VoodooGroupCommand.GroupInitInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<VoodooGroupCommand.GroupInitInfo>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PreCommand_d__3.NativeFieldInfoPtr_groupInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<VoodooGroupCommand.GroupInitInfo>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000405 RID: 1029
			// (get) Token: 0x06000D80 RID: 3456 RVA: 0x00034D9C File Offset: 0x00032F9C
			// (set) Token: 0x06000D81 RID: 3457 RVA: 0x00008B3B File Offset: 0x00006D3B
			public unsafe VoodooGroupedSequence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PreCommand_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooGroupedSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PreCommand_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000406 RID: 1030
			// (get) Token: 0x06000D82 RID: 3458 RVA: 0x00034DCC File Offset: 0x00032FCC
			// (set) Token: 0x06000D83 RID: 3459 RVA: 0x00008B5A File Offset: 0x00006D5A
			public unsafe Command command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PreCommand_d__3.NativeFieldInfoPtr_command);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PreCommand_d__3.NativeFieldInfoPtr_command), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000407 RID: 1031
			// (get) Token: 0x06000D84 RID: 3460 RVA: 0x00034DFC File Offset: 0x00032FFC
			// (set) Token: 0x06000D85 RID: 3461 RVA: 0x00008B79 File Offset: 0x00006D79
			public unsafe VoodooGroupCommand _groupCommand_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PreCommand_d__3.NativeFieldInfoPtr__groupCommand_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooGroupCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupedSequence._PreCommand_d__3.NativeFieldInfoPtr__groupCommand_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000858 RID: 2136
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000859 RID: 2137
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400085A RID: 2138
			private static readonly IntPtr NativeFieldInfoPtr_groupInfo;

			// Token: 0x0400085B RID: 2139
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400085C RID: 2140
			private static readonly IntPtr NativeFieldInfoPtr_command;

			// Token: 0x0400085D RID: 2141
			private static readonly IntPtr NativeFieldInfoPtr__groupCommand_5__2;

			// Token: 0x0400085E RID: 2142
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400085F RID: 2143
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000860 RID: 2144
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000861 RID: 2145
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000862 RID: 2146
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000863 RID: 2147
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
