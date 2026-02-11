using System;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace voodoo
{
	// Token: 0x02000016 RID: 22
	public class VoodooEntityDestroyedCommand : Command
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x0000B010 File Offset: 0x00009210
		// Note: this type is marked as 'beforefieldinit'.
		static VoodooEntityDestroyedCommand()
		{
			Il2CppClassPointerStore<VoodooEntityDestroyedCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo", "VoodooEntityDestroyedCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooEntityDestroyedCommand>.NativeClassPtr);
			VoodooEntityDestroyedCommand.NativeFieldInfoPtr_EntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityDestroyedCommand>.NativeClassPtr, "EntityID");
			VoodooEntityDestroyedCommand.NativeMethodInfoPtr__ctor_Public_Void_EntityDestroyed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityDestroyedCommand>.NativeClassPtr, 100663371);
			VoodooEntityDestroyedCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityDestroyedCommand>.NativeClassPtr, 100663372);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000B07C File Offset: 0x0000927C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106880, XrefRangeEnd = 1106883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooEntityDestroyedCommand(EntityDestroyed message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooEntityDestroyedCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityDestroyedCommand.NativeMethodInfoPtr__ctor_Public_Void_EntityDestroyed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000B0C8 File Offset: 0x000092C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106883, XrefRangeEnd = 1106888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooEntityDestroyedCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000264B File Offset: 0x0000084B
		public VoodooEntityDestroyedCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000B114 File Offset: 0x00009314
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002654 File Offset: 0x00000854
		public unsafe EntityID EntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityDestroyedCommand.NativeFieldInfoPtr_EntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityDestroyedCommand.NativeFieldInfoPtr_EntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_EntityID;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityDestroyed_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x020000B4 RID: 180
		[ObfuscatedName("voodoo.VoodooEntityDestroyedCommand+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06000A1E RID: 2590 RVA: 0x0002AE68 File Offset: 0x00029068
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<VoodooEntityDestroyedCommand._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooEntityDestroyedCommand>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooEntityDestroyedCommand._execute_d__2>.NativeClassPtr);
				VoodooEntityDestroyedCommand._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityDestroyedCommand._execute_d__2>.NativeClassPtr, "<>1__state");
				VoodooEntityDestroyedCommand._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityDestroyedCommand._execute_d__2>.NativeClassPtr, "<>2__current");
				VoodooEntityDestroyedCommand._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityDestroyedCommand._execute_d__2>.NativeClassPtr, "<>4__this");
				VoodooEntityDestroyedCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityDestroyedCommand._execute_d__2>.NativeClassPtr, 100663373);
				VoodooEntityDestroyedCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityDestroyedCommand._execute_d__2>.NativeClassPtr, 100663374);
				VoodooEntityDestroyedCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityDestroyedCommand._execute_d__2>.NativeClassPtr, 100663375);
				VoodooEntityDestroyedCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityDestroyedCommand._execute_d__2>.NativeClassPtr, 100663376);
				VoodooEntityDestroyedCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityDestroyedCommand._execute_d__2>.NativeClassPtr, 100663377);
				VoodooEntityDestroyedCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityDestroyedCommand._execute_d__2>.NativeClassPtr, 100663378);
			}

			// Token: 0x06000A1F RID: 2591 RVA: 0x0002AF48 File Offset: 0x00029148
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooEntityDestroyedCommand._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityDestroyedCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000A20 RID: 2592 RVA: 0x0002AF90 File Offset: 0x00029190
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityDestroyedCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A21 RID: 2593 RVA: 0x0002AFC4 File Offset: 0x000291C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106855, XrefRangeEnd = 1106875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityDestroyedCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170002F0 RID: 752
			// (get) Token: 0x06000A22 RID: 2594 RVA: 0x0002B000 File Offset: 0x00029200
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityDestroyedCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000A23 RID: 2595 RVA: 0x0002B040 File Offset: 0x00029240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106875, XrefRangeEnd = 1106880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityDestroyedCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170002F1 RID: 753
			// (get) Token: 0x06000A24 RID: 2596 RVA: 0x0002B074 File Offset: 0x00029274
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityDestroyedCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000A25 RID: 2597 RVA: 0x00006F00 File Offset: 0x00005100
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002ED RID: 749
			// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0002B0B4 File Offset: 0x000292B4
			// (set) Token: 0x06000A27 RID: 2599 RVA: 0x00006F09 File Offset: 0x00005109
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityDestroyedCommand._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityDestroyedCommand._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170002EE RID: 750
			// (get) Token: 0x06000A28 RID: 2600 RVA: 0x0002B0DC File Offset: 0x000292DC
			// (set) Token: 0x06000A29 RID: 2601 RVA: 0x00006F24 File Offset: 0x00005124
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityDestroyedCommand._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityDestroyedCommand._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002EF RID: 751
			// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0002B10C File Offset: 0x0002930C
			// (set) Token: 0x06000A2B RID: 2603 RVA: 0x00006F43 File Offset: 0x00005143
			public unsafe VoodooEntityDestroyedCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityDestroyedCommand._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooEntityDestroyedCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityDestroyedCommand._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000648 RID: 1608
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000649 RID: 1609
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400064A RID: 1610
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400064B RID: 1611
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400064C RID: 1612
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400064D RID: 1613
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400064E RID: 1614
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400064F RID: 1615
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000650 RID: 1616
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
