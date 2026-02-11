using System;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.match.data;
using dwd.core.match.sequence.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace lotus
{
	// Token: 0x02000087 RID: 135
	public class VoodooLinearSequence : SequenceCommand
	{
		// Token: 0x0600081A RID: 2074 RVA: 0x0002452C File Offset: 0x0002272C
		// Note: this type is marked as 'beforefieldinit'.
		static VoodooLinearSequence()
		{
			Il2CppClassPointerStore<VoodooLinearSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "VoodooLinearSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooLinearSequence>.NativeClassPtr);
			VoodooLinearSequence.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooLinearSequence>.NativeClassPtr, "entitiesProvider");
			VoodooLinearSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence>.NativeClassPtr, 100664430);
			VoodooLinearSequence.NativeMethodInfoPtr_executeSequence_Protected_Virtual_Final_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence>.NativeClassPtr, 100664431);
			VoodooLinearSequence.NativeMethodInfoPtr_PreSequence_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence>.NativeClassPtr, 100664432);
			VoodooLinearSequence.NativeMethodInfoPtr_PreCommand_Protected_Virtual_New_IEnumerator_Command_Nullable_1_GroupInitInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence>.NativeClassPtr, 100664433);
			VoodooLinearSequence.NativeMethodInfoPtr_PostSequence_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence>.NativeClassPtr, 100664434);
			VoodooLinearSequence.NativeMethodInfoPtr_CreateGroupCommand_Protected_Virtual_New_VoodooGroupCommand_Command_GroupInitInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence>.NativeClassPtr, 100664435);
			VoodooLinearSequence.NativeMethodInfoPtr_SetGroupCommandAttributes_Protected_Void_Command_VoodooGroupCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence>.NativeClassPtr, 100664436);
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x000245FC File Offset: 0x000227FC
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 719643, RefRangeEnd = 719682, XrefRangeStart = 719643, XrefRangeEnd = 719682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooLinearSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooLinearSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x0002466C File Offset: 0x0002286C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115781, XrefRangeEnd = 1115786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator executeSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence.NativeMethodInfoPtr_executeSequence_Protected_Virtual_Final_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x000246AC File Offset: 0x000228AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115786, XrefRangeEnd = 1115790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator PreSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooLinearSequence.NativeMethodInfoPtr_PreSequence_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x000246F8 File Offset: 0x000228F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115790, XrefRangeEnd = 1115794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator PreCommand(Command command, Nullable<VoodooGroupCommand.GroupInitInfo> groupInfo)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooLinearSequence.NativeMethodInfoPtr_PreCommand_Protected_Virtual_New_IEnumerator_Command_Nullable_1_GroupInitInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x0002476C File Offset: 0x0002296C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115794, XrefRangeEnd = 1115798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator PostSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooLinearSequence.NativeMethodInfoPtr_PostSequence_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x000247B8 File Offset: 0x000229B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115798, XrefRangeEnd = 1115804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual VoodooGroupCommand CreateGroupCommand(Command command, VoodooGroupCommand.GroupInitInfo groupInfo)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooLinearSequence.NativeMethodInfoPtr_CreateGroupCommand_Protected_Virtual_New_VoodooGroupCommand_Command_GroupInitInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VoodooGroupCommand>(intPtr3) : null;
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x0002482C File Offset: 0x00022A2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1115814, RefRangeEnd = 1115815, XrefRangeStart = 1115804, XrefRangeEnd = 1115814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGroupCommandAttributes(Command command, VoodooGroupCommand groupCommand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(groupCommand);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence.NativeMethodInfoPtr_SetGroupCommandAttributes_Protected_Void_Command_VoodooGroupCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00005F8D File Offset: 0x0000418D
		public VoodooLinearSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x00024880 File Offset: 0x00022A80
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x00005F96 File Offset: 0x00004196
		public unsafe EntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_executeSequence_Protected_Virtual_Final_IEnumerator_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_PreSequence_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_PreCommand_Protected_Virtual_New_IEnumerator_Command_Nullable_1_GroupInitInfo_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_PostSequence_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_CreateGroupCommand_Protected_Virtual_New_VoodooGroupCommand_Command_GroupInitInfo_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_SetGroupCommandAttributes_Protected_Void_Command_VoodooGroupCommand_0;

		// Token: 0x02000106 RID: 262
		[ObfuscatedName("lotus.VoodooLinearSequence+<PostSequence>d__5")]
		public sealed class _PostSequence_d__5 : Object
		{
			// Token: 0x06000D86 RID: 3462 RVA: 0x00034E2C File Offset: 0x0003302C
			// Note: this type is marked as 'beforefieldinit'.
			static _PostSequence_d__5()
			{
				Il2CppClassPointerStore<VoodooLinearSequence._PostSequence_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooLinearSequence>.NativeClassPtr, "<PostSequence>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooLinearSequence._PostSequence_d__5>.NativeClassPtr);
				VoodooLinearSequence._PostSequence_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooLinearSequence._PostSequence_d__5>.NativeClassPtr, "<>1__state");
				VoodooLinearSequence._PostSequence_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooLinearSequence._PostSequence_d__5>.NativeClassPtr, "<>2__current");
				VoodooLinearSequence._PostSequence_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._PostSequence_d__5>.NativeClassPtr, 100664437);
				VoodooLinearSequence._PostSequence_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._PostSequence_d__5>.NativeClassPtr, 100664438);
				VoodooLinearSequence._PostSequence_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._PostSequence_d__5>.NativeClassPtr, 100664439);
				VoodooLinearSequence._PostSequence_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._PostSequence_d__5>.NativeClassPtr, 100664440);
				VoodooLinearSequence._PostSequence_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._PostSequence_d__5>.NativeClassPtr, 100664441);
				VoodooLinearSequence._PostSequence_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._PostSequence_d__5>.NativeClassPtr, 100664442);
			}

			// Token: 0x06000D87 RID: 3463 RVA: 0x00034EF8 File Offset: 0x000330F8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PostSequence_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooLinearSequence._PostSequence_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._PostSequence_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D88 RID: 3464 RVA: 0x00034F40 File Offset: 0x00033140
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._PostSequence_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D89 RID: 3465 RVA: 0x00034F74 File Offset: 0x00033174
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._PostSequence_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700040C RID: 1036
			// (get) Token: 0x06000D8A RID: 3466 RVA: 0x00034FB0 File Offset: 0x000331B0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._PostSequence_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000D8B RID: 3467 RVA: 0x00034FF0 File Offset: 0x000331F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115680, XrefRangeEnd = 1115685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._PostSequence_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700040D RID: 1037
			// (get) Token: 0x06000D8C RID: 3468 RVA: 0x00035024 File Offset: 0x00033224
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._PostSequence_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000D8D RID: 3469 RVA: 0x00008B98 File Offset: 0x00006D98
			public _PostSequence_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700040A RID: 1034
			// (get) Token: 0x06000D8E RID: 3470 RVA: 0x00035064 File Offset: 0x00033264
			// (set) Token: 0x06000D8F RID: 3471 RVA: 0x00008BA1 File Offset: 0x00006DA1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._PostSequence_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._PostSequence_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700040B RID: 1035
			// (get) Token: 0x06000D90 RID: 3472 RVA: 0x0003508C File Offset: 0x0003328C
			// (set) Token: 0x06000D91 RID: 3473 RVA: 0x00008BBC File Offset: 0x00006DBC
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._PostSequence_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._PostSequence_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000864 RID: 2148
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000865 RID: 2149
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000866 RID: 2150
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000867 RID: 2151
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000868 RID: 2152
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000869 RID: 2153
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400086A RID: 2154
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400086B RID: 2155
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000107 RID: 263
		[ObfuscatedName("lotus.VoodooLinearSequence+<PreCommand>d__4")]
		public sealed class _PreCommand_d__4 : Object
		{
			// Token: 0x06000D92 RID: 3474 RVA: 0x000350BC File Offset: 0x000332BC
			// Note: this type is marked as 'beforefieldinit'.
			static _PreCommand_d__4()
			{
				Il2CppClassPointerStore<VoodooLinearSequence._PreCommand_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooLinearSequence>.NativeClassPtr, "<PreCommand>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooLinearSequence._PreCommand_d__4>.NativeClassPtr);
				VoodooLinearSequence._PreCommand_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooLinearSequence._PreCommand_d__4>.NativeClassPtr, "<>1__state");
				VoodooLinearSequence._PreCommand_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooLinearSequence._PreCommand_d__4>.NativeClassPtr, "<>2__current");
				VoodooLinearSequence._PreCommand_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._PreCommand_d__4>.NativeClassPtr, 100664443);
				VoodooLinearSequence._PreCommand_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._PreCommand_d__4>.NativeClassPtr, 100664444);
				VoodooLinearSequence._PreCommand_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._PreCommand_d__4>.NativeClassPtr, 100664445);
				VoodooLinearSequence._PreCommand_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._PreCommand_d__4>.NativeClassPtr, 100664446);
				VoodooLinearSequence._PreCommand_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._PreCommand_d__4>.NativeClassPtr, 100664447);
				VoodooLinearSequence._PreCommand_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._PreCommand_d__4>.NativeClassPtr, 100664448);
			}

			// Token: 0x06000D93 RID: 3475 RVA: 0x00035188 File Offset: 0x00033388
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PreCommand_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooLinearSequence._PreCommand_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._PreCommand_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D94 RID: 3476 RVA: 0x000351D0 File Offset: 0x000333D0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._PreCommand_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D95 RID: 3477 RVA: 0x00035204 File Offset: 0x00033404
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._PreCommand_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000410 RID: 1040
			// (get) Token: 0x06000D96 RID: 3478 RVA: 0x00035240 File Offset: 0x00033440
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._PreCommand_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000D97 RID: 3479 RVA: 0x00035280 File Offset: 0x00033480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115685, XrefRangeEnd = 1115690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._PreCommand_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000411 RID: 1041
			// (get) Token: 0x06000D98 RID: 3480 RVA: 0x000352B4 File Offset: 0x000334B4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._PreCommand_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000D99 RID: 3481 RVA: 0x00008BDB File Offset: 0x00006DDB
			public _PreCommand_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700040E RID: 1038
			// (get) Token: 0x06000D9A RID: 3482 RVA: 0x000352F4 File Offset: 0x000334F4
			// (set) Token: 0x06000D9B RID: 3483 RVA: 0x00008BE4 File Offset: 0x00006DE4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._PreCommand_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._PreCommand_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700040F RID: 1039
			// (get) Token: 0x06000D9C RID: 3484 RVA: 0x0003531C File Offset: 0x0003351C
			// (set) Token: 0x06000D9D RID: 3485 RVA: 0x00008BFF File Offset: 0x00006DFF
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._PreCommand_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._PreCommand_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400086C RID: 2156
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400086D RID: 2157
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400086E RID: 2158
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400086F RID: 2159
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000870 RID: 2160
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000871 RID: 2161
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000872 RID: 2162
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000873 RID: 2163
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000108 RID: 264
		[ObfuscatedName("lotus.VoodooLinearSequence+<PreSequence>d__3")]
		public sealed class _PreSequence_d__3 : Object
		{
			// Token: 0x06000D9E RID: 3486 RVA: 0x0003534C File Offset: 0x0003354C
			// Note: this type is marked as 'beforefieldinit'.
			static _PreSequence_d__3()
			{
				Il2CppClassPointerStore<VoodooLinearSequence._PreSequence_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooLinearSequence>.NativeClassPtr, "<PreSequence>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooLinearSequence._PreSequence_d__3>.NativeClassPtr);
				VoodooLinearSequence._PreSequence_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooLinearSequence._PreSequence_d__3>.NativeClassPtr, "<>1__state");
				VoodooLinearSequence._PreSequence_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooLinearSequence._PreSequence_d__3>.NativeClassPtr, "<>2__current");
				VoodooLinearSequence._PreSequence_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._PreSequence_d__3>.NativeClassPtr, 100664449);
				VoodooLinearSequence._PreSequence_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._PreSequence_d__3>.NativeClassPtr, 100664450);
				VoodooLinearSequence._PreSequence_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._PreSequence_d__3>.NativeClassPtr, 100664451);
				VoodooLinearSequence._PreSequence_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._PreSequence_d__3>.NativeClassPtr, 100664452);
				VoodooLinearSequence._PreSequence_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._PreSequence_d__3>.NativeClassPtr, 100664453);
				VoodooLinearSequence._PreSequence_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._PreSequence_d__3>.NativeClassPtr, 100664454);
			}

			// Token: 0x06000D9F RID: 3487 RVA: 0x00035418 File Offset: 0x00033618
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PreSequence_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooLinearSequence._PreSequence_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._PreSequence_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000DA0 RID: 3488 RVA: 0x00035460 File Offset: 0x00033660
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._PreSequence_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DA1 RID: 3489 RVA: 0x00035494 File Offset: 0x00033694
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._PreSequence_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000414 RID: 1044
			// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x000354D0 File Offset: 0x000336D0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._PreSequence_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000DA3 RID: 3491 RVA: 0x00035510 File Offset: 0x00033710
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115690, XrefRangeEnd = 1115695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._PreSequence_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000415 RID: 1045
			// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x00035544 File Offset: 0x00033744
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._PreSequence_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000DA5 RID: 3493 RVA: 0x00008C1E File Offset: 0x00006E1E
			public _PreSequence_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000412 RID: 1042
			// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x00035584 File Offset: 0x00033784
			// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x00008C27 File Offset: 0x00006E27
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._PreSequence_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._PreSequence_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000413 RID: 1043
			// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x000355AC File Offset: 0x000337AC
			// (set) Token: 0x06000DA9 RID: 3497 RVA: 0x00008C42 File Offset: 0x00006E42
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._PreSequence_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._PreSequence_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000874 RID: 2164
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000875 RID: 2165
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000876 RID: 2166
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000877 RID: 2167
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000878 RID: 2168
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000879 RID: 2169
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400087A RID: 2170
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400087B RID: 2171
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000109 RID: 265
		[ObfuscatedName("lotus.VoodooLinearSequence+<executeSequence>d__2")]
		public sealed class _executeSequence_d__2 : Object
		{
			// Token: 0x06000DAA RID: 3498 RVA: 0x000355DC File Offset: 0x000337DC
			// Note: this type is marked as 'beforefieldinit'.
			static _executeSequence_d__2()
			{
				Il2CppClassPointerStore<VoodooLinearSequence._executeSequence_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooLinearSequence>.NativeClassPtr, "<executeSequence>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooLinearSequence._executeSequence_d__2>.NativeClassPtr);
				VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooLinearSequence._executeSequence_d__2>.NativeClassPtr, "<>1__state");
				VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooLinearSequence._executeSequence_d__2>.NativeClassPtr, "<>2__current");
				VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooLinearSequence._executeSequence_d__2>.NativeClassPtr, "<>4__this");
				VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr__preSequence_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooLinearSequence._executeSequence_d__2>.NativeClassPtr, "<preSequence>5__2");
				VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr__postSequence_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooLinearSequence._executeSequence_d__2>.NativeClassPtr, "<postSequence>5__3");
				VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooLinearSequence._executeSequence_d__2>.NativeClassPtr, "<>7__wrap3");
				VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr__command_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooLinearSequence._executeSequence_d__2>.NativeClassPtr, "<command>5__5");
				VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr__groupInfo_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooLinearSequence._executeSequence_d__2>.NativeClassPtr, "<groupInfo>5__6");
				VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr__preCommand_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooLinearSequence._executeSequence_d__2>.NativeClassPtr, "<preCommand>5__7");
				VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr__groupCommand_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooLinearSequence._executeSequence_d__2>.NativeClassPtr, "<groupCommand>5__8");
				VoodooLinearSequence._executeSequence_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._executeSequence_d__2>.NativeClassPtr, 100664455);
				VoodooLinearSequence._executeSequence_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._executeSequence_d__2>.NativeClassPtr, 100664456);
				VoodooLinearSequence._executeSequence_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._executeSequence_d__2>.NativeClassPtr, 100664457);
				VoodooLinearSequence._executeSequence_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._executeSequence_d__2>.NativeClassPtr, 100664458);
				VoodooLinearSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._executeSequence_d__2>.NativeClassPtr, 100664459);
				VoodooLinearSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._executeSequence_d__2>.NativeClassPtr, 100664460);
				VoodooLinearSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooLinearSequence._executeSequence_d__2>.NativeClassPtr, 100664461);
			}

			// Token: 0x06000DAB RID: 3499 RVA: 0x0003575C File Offset: 0x0003395C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _executeSequence_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooLinearSequence._executeSequence_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._executeSequence_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000DAC RID: 3500 RVA: 0x000357A4 File Offset: 0x000339A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115695, XrefRangeEnd = 1115700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._executeSequence_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DAD RID: 3501 RVA: 0x000357D8 File Offset: 0x000339D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115700, XrefRangeEnd = 1115773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._executeSequence_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DAE RID: 3502 RVA: 0x00035814 File Offset: 0x00033A14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115773, XrefRangeEnd = 1115776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._executeSequence_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000420 RID: 1056
			// (get) Token: 0x06000DAF RID: 3503 RVA: 0x00035848 File Offset: 0x00033A48
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000DB0 RID: 3504 RVA: 0x00035888 File Offset: 0x00033A88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115776, XrefRangeEnd = 1115781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000421 RID: 1057
			// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x000358BC File Offset: 0x00033ABC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooLinearSequence._executeSequence_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000DB2 RID: 3506 RVA: 0x00008C61 File Offset: 0x00006E61
			public _executeSequence_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000416 RID: 1046
			// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x000358FC File Offset: 0x00033AFC
			// (set) Token: 0x06000DB4 RID: 3508 RVA: 0x00008C6A File Offset: 0x00006E6A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000417 RID: 1047
			// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x00035924 File Offset: 0x00033B24
			// (set) Token: 0x06000DB6 RID: 3510 RVA: 0x00008C85 File Offset: 0x00006E85
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000418 RID: 1048
			// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x00035954 File Offset: 0x00033B54
			// (set) Token: 0x06000DB8 RID: 3512 RVA: 0x00008CA4 File Offset: 0x00006EA4
			public unsafe VoodooLinearSequence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooLinearSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000419 RID: 1049
			// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x00035984 File Offset: 0x00033B84
			// (set) Token: 0x06000DBA RID: 3514 RVA: 0x00008CC3 File Offset: 0x00006EC3
			public unsafe IEnumerator _preSequence_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr__preSequence_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr__preSequence_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700041A RID: 1050
			// (get) Token: 0x06000DBB RID: 3515 RVA: 0x000359B4 File Offset: 0x00033BB4
			// (set) Token: 0x06000DBC RID: 3516 RVA: 0x00008CE2 File Offset: 0x00006EE2
			public unsafe IEnumerator _postSequence_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr__postSequence_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr__postSequence_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700041B RID: 1051
			// (get) Token: 0x06000DBD RID: 3517 RVA: 0x000359E4 File Offset: 0x00033BE4
			// (set) Token: 0x06000DBE RID: 3518 RVA: 0x00008D01 File Offset: 0x00006F01
			public unsafe IEnumerator<Command> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Command>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700041C RID: 1052
			// (get) Token: 0x06000DBF RID: 3519 RVA: 0x00035A14 File Offset: 0x00033C14
			// (set) Token: 0x06000DC0 RID: 3520 RVA: 0x00008D20 File Offset: 0x00006F20
			public unsafe Command _command_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr__command_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr__command_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700041D RID: 1053
			// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x00035A44 File Offset: 0x00033C44
			// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x00008D3F File Offset: 0x00006F3F
			public Nullable<VoodooGroupCommand.GroupInitInfo> _groupInfo_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr__groupInfo_5__6);
					return new Nullable<VoodooGroupCommand.GroupInitInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<VoodooGroupCommand.GroupInitInfo>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr__groupInfo_5__6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<VoodooGroupCommand.GroupInitInfo>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700041E RID: 1054
			// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x00035A74 File Offset: 0x00033C74
			// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x00008D6D File Offset: 0x00006F6D
			public unsafe IEnumerator _preCommand_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr__preCommand_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr__preCommand_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700041F RID: 1055
			// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x00035AA4 File Offset: 0x00033CA4
			// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x00008D8C File Offset: 0x00006F8C
			public unsafe VoodooGroupCommand _groupCommand_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr__groupCommand_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooGroupCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooLinearSequence._executeSequence_d__2.NativeFieldInfoPtr__groupCommand_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400087C RID: 2172
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400087D RID: 2173
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400087E RID: 2174
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400087F RID: 2175
			private static readonly IntPtr NativeFieldInfoPtr__preSequence_5__2;

			// Token: 0x04000880 RID: 2176
			private static readonly IntPtr NativeFieldInfoPtr__postSequence_5__3;

			// Token: 0x04000881 RID: 2177
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04000882 RID: 2178
			private static readonly IntPtr NativeFieldInfoPtr__command_5__5;

			// Token: 0x04000883 RID: 2179
			private static readonly IntPtr NativeFieldInfoPtr__groupInfo_5__6;

			// Token: 0x04000884 RID: 2180
			private static readonly IntPtr NativeFieldInfoPtr__preCommand_5__7;

			// Token: 0x04000885 RID: 2181
			private static readonly IntPtr NativeFieldInfoPtr__groupCommand_5__8;

			// Token: 0x04000886 RID: 2182
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000887 RID: 2183
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000888 RID: 2184
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000889 RID: 2185
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400088A RID: 2186
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400088B RID: 2187
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400088C RID: 2188
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
