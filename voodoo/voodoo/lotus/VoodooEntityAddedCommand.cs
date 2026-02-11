using System;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace lotus
{
	// Token: 0x02000061 RID: 97
	public class VoodooEntityAddedCommand : Command
	{
		// Token: 0x06000594 RID: 1428 RVA: 0x0001BDB0 File Offset: 0x00019FB0
		// Note: this type is marked as 'beforefieldinit'.
		static VoodooEntityAddedCommand()
		{
			Il2CppClassPointerStore<VoodooEntityAddedCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "VoodooEntityAddedCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooEntityAddedCommand>.NativeClassPtr);
			VoodooEntityAddedCommand.NativeFieldInfoPtr_EntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityAddedCommand>.NativeClassPtr, "EntityID");
			VoodooEntityAddedCommand.NativeFieldInfoPtr_ParentEntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityAddedCommand>.NativeClassPtr, "ParentEntityID");
			VoodooEntityAddedCommand.NativeFieldInfoPtr_OwningPlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityAddedCommand>.NativeClassPtr, "OwningPlayerID");
			VoodooEntityAddedCommand.NativeFieldInfoPtr_um = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityAddedCommand>.NativeClassPtr, "um");
			VoodooEntityAddedCommand.NativeMethodInfoPtr__ctor_Public_Void_EntityAdded_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityAddedCommand>.NativeClassPtr, 100664058);
			VoodooEntityAddedCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityAddedCommand>.NativeClassPtr, 100664059);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0001BE58 File Offset: 0x0001A058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111876, XrefRangeEnd = 1111885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooEntityAddedCommand(EntityAdded message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooEntityAddedCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityAddedCommand.NativeMethodInfoPtr__ctor_Public_Void_EntityAdded_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0001BEA4 File Offset: 0x0001A0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111885, XrefRangeEnd = 1111890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooEntityAddedCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00004B8F File Offset: 0x00002D8F
		public VoodooEntityAddedCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x0001BEF0 File Offset: 0x0001A0F0
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x00004B98 File Offset: 0x00002D98
		public unsafe EntityID EntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityAddedCommand.NativeFieldInfoPtr_EntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityAddedCommand.NativeFieldInfoPtr_EntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x0001BF20 File Offset: 0x0001A120
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x00004BB7 File Offset: 0x00002DB7
		public unsafe EntityID ParentEntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityAddedCommand.NativeFieldInfoPtr_ParentEntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityAddedCommand.NativeFieldInfoPtr_ParentEntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x0001BF50 File Offset: 0x0001A150
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x00004BD6 File Offset: 0x00002DD6
		public unsafe AccountID OwningPlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityAddedCommand.NativeFieldInfoPtr_OwningPlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityAddedCommand.NativeFieldInfoPtr_OwningPlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x0001BF80 File Offset: 0x0001A180
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x00004BF5 File Offset: 0x00002DF5
		public unsafe UpdateManager um
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityAddedCommand.NativeFieldInfoPtr_um);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityAddedCommand.NativeFieldInfoPtr_um), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeFieldInfoPtr_EntityID;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeFieldInfoPtr_ParentEntityID;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeFieldInfoPtr_OwningPlayerID;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeFieldInfoPtr_um;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityAdded_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x020000E4 RID: 228
		[ObfuscatedName("lotus.VoodooEntityAddedCommand+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x06000BFD RID: 3069 RVA: 0x00030774 File Offset: 0x0002E974
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<VoodooEntityAddedCommand._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooEntityAddedCommand>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooEntityAddedCommand._execute_d__5>.NativeClassPtr);
				VoodooEntityAddedCommand._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityAddedCommand._execute_d__5>.NativeClassPtr, "<>1__state");
				VoodooEntityAddedCommand._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityAddedCommand._execute_d__5>.NativeClassPtr, "<>2__current");
				VoodooEntityAddedCommand._execute_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityAddedCommand._execute_d__5>.NativeClassPtr, "<>4__this");
				VoodooEntityAddedCommand._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityAddedCommand._execute_d__5>.NativeClassPtr, 100664060);
				VoodooEntityAddedCommand._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityAddedCommand._execute_d__5>.NativeClassPtr, 100664061);
				VoodooEntityAddedCommand._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityAddedCommand._execute_d__5>.NativeClassPtr, 100664062);
				VoodooEntityAddedCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityAddedCommand._execute_d__5>.NativeClassPtr, 100664063);
				VoodooEntityAddedCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityAddedCommand._execute_d__5>.NativeClassPtr, 100664064);
				VoodooEntityAddedCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityAddedCommand._execute_d__5>.NativeClassPtr, 100664065);
			}

			// Token: 0x06000BFE RID: 3070 RVA: 0x00030854 File Offset: 0x0002EA54
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooEntityAddedCommand._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityAddedCommand._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000BFF RID: 3071 RVA: 0x0003089C File Offset: 0x0002EA9C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityAddedCommand._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C00 RID: 3072 RVA: 0x000308D0 File Offset: 0x0002EAD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111865, XrefRangeEnd = 1111871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityAddedCommand._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700038D RID: 909
			// (get) Token: 0x06000C01 RID: 3073 RVA: 0x0003090C File Offset: 0x0002EB0C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityAddedCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C02 RID: 3074 RVA: 0x0003094C File Offset: 0x0002EB4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111871, XrefRangeEnd = 1111876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityAddedCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700038E RID: 910
			// (get) Token: 0x06000C03 RID: 3075 RVA: 0x00030980 File Offset: 0x0002EB80
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityAddedCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C04 RID: 3076 RVA: 0x00007E0A File Offset: 0x0000600A
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700038A RID: 906
			// (get) Token: 0x06000C05 RID: 3077 RVA: 0x000309C0 File Offset: 0x0002EBC0
			// (set) Token: 0x06000C06 RID: 3078 RVA: 0x00007E13 File Offset: 0x00006013
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityAddedCommand._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityAddedCommand._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700038B RID: 907
			// (get) Token: 0x06000C07 RID: 3079 RVA: 0x000309E8 File Offset: 0x0002EBE8
			// (set) Token: 0x06000C08 RID: 3080 RVA: 0x00007E2E File Offset: 0x0000602E
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityAddedCommand._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityAddedCommand._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700038C RID: 908
			// (get) Token: 0x06000C09 RID: 3081 RVA: 0x00030A18 File Offset: 0x0002EC18
			// (set) Token: 0x06000C0A RID: 3082 RVA: 0x00007E4D File Offset: 0x0000604D
			public unsafe VoodooEntityAddedCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityAddedCommand._execute_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooEntityAddedCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityAddedCommand._execute_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400077E RID: 1918
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400077F RID: 1919
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000780 RID: 1920
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000781 RID: 1921
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000782 RID: 1922
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000783 RID: 1923
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000784 RID: 1924
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000785 RID: 1925
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000786 RID: 1926
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
