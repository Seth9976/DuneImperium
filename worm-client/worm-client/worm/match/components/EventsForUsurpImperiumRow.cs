using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;

namespace worm.match.components
{
	// Token: 0x020001B0 RID: 432
	public class EventsForUsurpImperiumRow : VersionedView<IAttribute<EntityID>>
	{
		// Token: 0x06001313 RID: 4883 RVA: 0x00051FC4 File Offset: 0x000501C4
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForUsurpImperiumRow()
		{
			Il2CppClassPointerStore<EventsForUsurpImperiumRow>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "EventsForUsurpImperiumRow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForUsurpImperiumRow>.NativeClassPtr);
			EventsForUsurpImperiumRow.NativeFieldInfoPtr_inImperiumRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForUsurpImperiumRow>.NativeClassPtr, "inImperiumRow");
			EventsForUsurpImperiumRow.NativeFieldInfoPtr_onUsurped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForUsurpImperiumRow>.NativeClassPtr, "onUsurped");
			EventsForUsurpImperiumRow.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForUsurpImperiumRow>.NativeClassPtr, 100665903);
			EventsForUsurpImperiumRow.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForUsurpImperiumRow>.NativeClassPtr, 100665904);
			EventsForUsurpImperiumRow.NativeMethodInfoPtr_SetInImperiumRow_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForUsurpImperiumRow>.NativeClassPtr, 100665905);
			EventsForUsurpImperiumRow.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForUsurpImperiumRow>.NativeClassPtr, 100665906);
			EventsForUsurpImperiumRow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForUsurpImperiumRow>.NativeClassPtr, 100665907);
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00052080 File Offset: 0x00050280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712720, XrefRangeEnd = 712729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForUsurpImperiumRow.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x000520BC File Offset: 0x000502BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712729, XrefRangeEnd = 712734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForUsurpImperiumRow.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x000520FC File Offset: 0x000502FC
		[CallerCount(0)]
		public unsafe void SetInImperiumRow(bool inRow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inRow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForUsurpImperiumRow.NativeMethodInfoPtr_SetInImperiumRow_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0005213C File Offset: 0x0005033C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712734, XrefRangeEnd = 712744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForUsurpImperiumRow.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00052178 File Offset: 0x00050378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712744, XrefRangeEnd = 712752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForUsurpImperiumRow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForUsurpImperiumRow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForUsurpImperiumRow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x0000BDDC File Offset: 0x00009FDC
		public EventsForUsurpImperiumRow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x0600131A RID: 4890 RVA: 0x000521B4 File Offset: 0x000503B4
		// (set) Token: 0x0600131B RID: 4891 RVA: 0x0000BDE5 File Offset: 0x00009FE5
		public unsafe bool inImperiumRow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForUsurpImperiumRow.NativeFieldInfoPtr_inImperiumRow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForUsurpImperiumRow.NativeFieldInfoPtr_inImperiumRow)) = value;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x0600131C RID: 4892 RVA: 0x000521DC File Offset: 0x000503DC
		// (set) Token: 0x0600131D RID: 4893 RVA: 0x0000BE00 File Offset: 0x0000A000
		public unsafe BoolUnityEvents onUsurped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForUsurpImperiumRow.NativeFieldInfoPtr_onUsurped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForUsurpImperiumRow.NativeFieldInfoPtr_onUsurped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeFieldInfoPtr_inImperiumRow;

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeFieldInfoPtr_onUsurped;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeMethodInfoPtr_SetInImperiumRow_Public_Void_Boolean_0;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003C5 RID: 965
		[ObfuscatedName("worm.match.components.EventsForUsurpImperiumRow+<Init>d__3")]
		public sealed class _Init_d__3 : Object
		{
			// Token: 0x060026FC RID: 9980 RVA: 0x0008E698 File Offset: 0x0008C898
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__3()
			{
				Il2CppClassPointerStore<EventsForUsurpImperiumRow._Init_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventsForUsurpImperiumRow>.NativeClassPtr, "<Init>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForUsurpImperiumRow._Init_d__3>.NativeClassPtr);
				EventsForUsurpImperiumRow._Init_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForUsurpImperiumRow._Init_d__3>.NativeClassPtr, "<>1__state");
				EventsForUsurpImperiumRow._Init_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForUsurpImperiumRow._Init_d__3>.NativeClassPtr, "<>2__current");
				EventsForUsurpImperiumRow._Init_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForUsurpImperiumRow._Init_d__3>.NativeClassPtr, "<>4__this");
				EventsForUsurpImperiumRow._Init_d__3.NativeFieldInfoPtr__view_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForUsurpImperiumRow._Init_d__3>.NativeClassPtr, "<view>5__2");
				EventsForUsurpImperiumRow._Init_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForUsurpImperiumRow._Init_d__3>.NativeClassPtr, 100665908);
				EventsForUsurpImperiumRow._Init_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForUsurpImperiumRow._Init_d__3>.NativeClassPtr, 100665909);
				EventsForUsurpImperiumRow._Init_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForUsurpImperiumRow._Init_d__3>.NativeClassPtr, 100665910);
				EventsForUsurpImperiumRow._Init_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForUsurpImperiumRow._Init_d__3>.NativeClassPtr, 100665911);
				EventsForUsurpImperiumRow._Init_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForUsurpImperiumRow._Init_d__3>.NativeClassPtr, 100665912);
				EventsForUsurpImperiumRow._Init_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForUsurpImperiumRow._Init_d__3>.NativeClassPtr, 100665913);
			}

			// Token: 0x060026FD RID: 9981 RVA: 0x0008E78C File Offset: 0x0008C98C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForUsurpImperiumRow._Init_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForUsurpImperiumRow._Init_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060026FE RID: 9982 RVA: 0x0008E7D4 File Offset: 0x0008C9D4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForUsurpImperiumRow._Init_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026FF RID: 9983 RVA: 0x0008E808 File Offset: 0x0008CA08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712707, XrefRangeEnd = 712715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForUsurpImperiumRow._Init_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000ADB RID: 2779
			// (get) Token: 0x06002700 RID: 9984 RVA: 0x0008E844 File Offset: 0x0008CA44
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForUsurpImperiumRow._Init_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002701 RID: 9985 RVA: 0x0008E884 File Offset: 0x0008CA84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712715, XrefRangeEnd = 712720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForUsurpImperiumRow._Init_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000ADC RID: 2780
			// (get) Token: 0x06002702 RID: 9986 RVA: 0x0008E8B8 File Offset: 0x0008CAB8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForUsurpImperiumRow._Init_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002703 RID: 9987 RVA: 0x00015790 File Offset: 0x00013990
			public _Init_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AD7 RID: 2775
			// (get) Token: 0x06002704 RID: 9988 RVA: 0x0008E8F8 File Offset: 0x0008CAF8
			// (set) Token: 0x06002705 RID: 9989 RVA: 0x00015799 File Offset: 0x00013999
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForUsurpImperiumRow._Init_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForUsurpImperiumRow._Init_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AD8 RID: 2776
			// (get) Token: 0x06002706 RID: 9990 RVA: 0x0008E920 File Offset: 0x0008CB20
			// (set) Token: 0x06002707 RID: 9991 RVA: 0x000157B4 File Offset: 0x000139B4
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForUsurpImperiumRow._Init_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForUsurpImperiumRow._Init_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AD9 RID: 2777
			// (get) Token: 0x06002708 RID: 9992 RVA: 0x0008E950 File Offset: 0x0008CB50
			// (set) Token: 0x06002709 RID: 9993 RVA: 0x000157D3 File Offset: 0x000139D3
			public unsafe EventsForUsurpImperiumRow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForUsurpImperiumRow._Init_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventsForUsurpImperiumRow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForUsurpImperiumRow._Init_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ADA RID: 2778
			// (get) Token: 0x0600270A RID: 9994 RVA: 0x0008E980 File Offset: 0x0008CB80
			// (set) Token: 0x0600270B RID: 9995 RVA: 0x000157F2 File Offset: 0x000139F2
			public unsafe EntityView _view_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForUsurpImperiumRow._Init_d__3.NativeFieldInfoPtr__view_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForUsurpImperiumRow._Init_d__3.NativeFieldInfoPtr__view_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001672 RID: 5746
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001673 RID: 5747
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001674 RID: 5748
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001675 RID: 5749
			private static readonly IntPtr NativeFieldInfoPtr__view_5__2;

			// Token: 0x04001676 RID: 5750
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001677 RID: 5751
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001678 RID: 5752
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001679 RID: 5753
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400167A RID: 5754
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400167B RID: 5755
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
