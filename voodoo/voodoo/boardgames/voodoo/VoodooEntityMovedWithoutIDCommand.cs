using System;
using Canis.attributes;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;

namespace boardgames.voodoo
{
	// Token: 0x0200009B RID: 155
	public class VoodooEntityMovedWithoutIDCommand : Command
	{
		// Token: 0x06000918 RID: 2328 RVA: 0x000279D0 File Offset: 0x00025BD0
		// Note: this type is marked as 'beforefieldinit'.
		static VoodooEntityMovedWithoutIDCommand()
		{
			Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.voodoo", "VoodooEntityMovedWithoutIDCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand>.NativeClassPtr);
			VoodooEntityMovedWithoutIDCommand.NativeFieldInfoPtr_SourceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand>.NativeClassPtr, "SourceID");
			VoodooEntityMovedWithoutIDCommand.NativeFieldInfoPtr_DestinationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand>.NativeClassPtr, "DestinationID");
			VoodooEntityMovedWithoutIDCommand.NativeFieldInfoPtr_PositionInParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand>.NativeClassPtr, "PositionInParent");
			VoodooEntityMovedWithoutIDCommand.NativeFieldInfoPtr_um = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand>.NativeClassPtr, "um");
			VoodooEntityMovedWithoutIDCommand.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand>.NativeClassPtr, "Attributes");
			VoodooEntityMovedWithoutIDCommand.NativeMethodInfoPtr__ctor_Public_Void_EntityMovedWithoutID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand>.NativeClassPtr, 100664620);
			VoodooEntityMovedWithoutIDCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand>.NativeClassPtr, 100664621);
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00027A8C File Offset: 0x00025C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117173, XrefRangeEnd = 1117182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooEntityMovedWithoutIDCommand(EntityMovedWithoutID message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityMovedWithoutIDCommand.NativeMethodInfoPtr__ctor_Public_Void_EntityMovedWithoutID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00027AD8 File Offset: 0x00025CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117182, XrefRangeEnd = 1117187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooEntityMovedWithoutIDCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0000674F File Offset: 0x0000494F
		public VoodooEntityMovedWithoutIDCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x00027B24 File Offset: 0x00025D24
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x00006758 File Offset: 0x00004958
		public unsafe EntityID SourceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedWithoutIDCommand.NativeFieldInfoPtr_SourceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedWithoutIDCommand.NativeFieldInfoPtr_SourceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x00027B54 File Offset: 0x00025D54
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x00006777 File Offset: 0x00004977
		public unsafe EntityID DestinationID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedWithoutIDCommand.NativeFieldInfoPtr_DestinationID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedWithoutIDCommand.NativeFieldInfoPtr_DestinationID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x00027B84 File Offset: 0x00025D84
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x00006796 File Offset: 0x00004996
		public unsafe int PositionInParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedWithoutIDCommand.NativeFieldInfoPtr_PositionInParent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedWithoutIDCommand.NativeFieldInfoPtr_PositionInParent)) = value;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x00027BAC File Offset: 0x00025DAC
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x000067B1 File Offset: 0x000049B1
		public unsafe UpdateManager um
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedWithoutIDCommand.NativeFieldInfoPtr_um);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedWithoutIDCommand.NativeFieldInfoPtr_um), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x00027BDC File Offset: 0x00025DDC
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x000067D0 File Offset: 0x000049D0
		public unsafe ReadOnlyAttributes Attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedWithoutIDCommand.NativeFieldInfoPtr_Attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedWithoutIDCommand.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeFieldInfoPtr_SourceID;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeFieldInfoPtr_DestinationID;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeFieldInfoPtr_PositionInParent;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeFieldInfoPtr_um;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityMovedWithoutID_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000117 RID: 279
		[ObfuscatedName("boardgames.voodoo.VoodooEntityMovedWithoutIDCommand+<execute>d__6")]
		public sealed class _execute_d__6 : Object
		{
			// Token: 0x06000E76 RID: 3702 RVA: 0x00037C98 File Offset: 0x00035E98
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__6()
			{
				Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand._execute_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand>.NativeClassPtr, "<execute>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand._execute_d__6>.NativeClassPtr);
				VoodooEntityMovedWithoutIDCommand._execute_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand._execute_d__6>.NativeClassPtr, "<>1__state");
				VoodooEntityMovedWithoutIDCommand._execute_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand._execute_d__6>.NativeClassPtr, "<>2__current");
				VoodooEntityMovedWithoutIDCommand._execute_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand._execute_d__6>.NativeClassPtr, "<>4__this");
				VoodooEntityMovedWithoutIDCommand._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand._execute_d__6>.NativeClassPtr, 100664622);
				VoodooEntityMovedWithoutIDCommand._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand._execute_d__6>.NativeClassPtr, 100664623);
				VoodooEntityMovedWithoutIDCommand._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand._execute_d__6>.NativeClassPtr, 100664624);
				VoodooEntityMovedWithoutIDCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand._execute_d__6>.NativeClassPtr, 100664625);
				VoodooEntityMovedWithoutIDCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand._execute_d__6>.NativeClassPtr, 100664626);
				VoodooEntityMovedWithoutIDCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand._execute_d__6>.NativeClassPtr, 100664627);
			}

			// Token: 0x06000E77 RID: 3703 RVA: 0x00037D78 File Offset: 0x00035F78
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooEntityMovedWithoutIDCommand._execute_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityMovedWithoutIDCommand._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000E78 RID: 3704 RVA: 0x00037DC0 File Offset: 0x00035FC0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityMovedWithoutIDCommand._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E79 RID: 3705 RVA: 0x00037DF4 File Offset: 0x00035FF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117158, XrefRangeEnd = 1117168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityMovedWithoutIDCommand._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000462 RID: 1122
			// (get) Token: 0x06000E7A RID: 3706 RVA: 0x00037E30 File Offset: 0x00036030
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityMovedWithoutIDCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E7B RID: 3707 RVA: 0x00037E70 File Offset: 0x00036070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117168, XrefRangeEnd = 1117173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityMovedWithoutIDCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000463 RID: 1123
			// (get) Token: 0x06000E7C RID: 3708 RVA: 0x00037EA4 File Offset: 0x000360A4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooEntityMovedWithoutIDCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E7D RID: 3709 RVA: 0x000092E4 File Offset: 0x000074E4
			public _execute_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700045F RID: 1119
			// (get) Token: 0x06000E7E RID: 3710 RVA: 0x00037EE4 File Offset: 0x000360E4
			// (set) Token: 0x06000E7F RID: 3711 RVA: 0x000092ED File Offset: 0x000074ED
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedWithoutIDCommand._execute_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedWithoutIDCommand._execute_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000460 RID: 1120
			// (get) Token: 0x06000E80 RID: 3712 RVA: 0x00037F0C File Offset: 0x0003610C
			// (set) Token: 0x06000E81 RID: 3713 RVA: 0x00009308 File Offset: 0x00007508
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedWithoutIDCommand._execute_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedWithoutIDCommand._execute_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000461 RID: 1121
			// (get) Token: 0x06000E82 RID: 3714 RVA: 0x00037F3C File Offset: 0x0003613C
			// (set) Token: 0x06000E83 RID: 3715 RVA: 0x00009327 File Offset: 0x00007527
			public unsafe VoodooEntityMovedWithoutIDCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedWithoutIDCommand._execute_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooEntityMovedWithoutIDCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooEntityMovedWithoutIDCommand._execute_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008F9 RID: 2297
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040008FA RID: 2298
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040008FB RID: 2299
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040008FC RID: 2300
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040008FD RID: 2301
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008FE RID: 2302
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040008FF RID: 2303
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000900 RID: 2304
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000901 RID: 2305
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
