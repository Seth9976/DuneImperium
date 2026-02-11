using System;
using Canis.utils.ids;
using dwd.core.match;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using TMPro;

namespace worm.match.dataRenderers
{
	// Token: 0x020000F4 RID: 244
	public class OwnedChildCountRenderer : Observer
	{
		// Token: 0x06000AB3 RID: 2739 RVA: 0x00038A70 File Offset: 0x00036C70
		// Note: this type is marked as 'beforefieldinit'.
		static OwnedChildCountRenderer()
		{
			Il2CppClassPointerStore<OwnedChildCountRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "OwnedChildCountRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OwnedChildCountRenderer>.NativeClassPtr);
			OwnedChildCountRenderer.NativeFieldInfoPtr_ownerView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OwnedChildCountRenderer>.NativeClassPtr, "ownerView");
			OwnedChildCountRenderer.NativeFieldInfoPtr_countText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OwnedChildCountRenderer>.NativeClassPtr, "countText");
			OwnedChildCountRenderer.NativeFieldInfoPtr_onIsEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OwnedChildCountRenderer>.NativeClassPtr, "onIsEmpty");
			OwnedChildCountRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OwnedChildCountRenderer>.NativeClassPtr, 100664772);
			OwnedChildCountRenderer.NativeMethodInfoPtr_WaitForOwner_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OwnedChildCountRenderer>.NativeClassPtr, 100664773);
			OwnedChildCountRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OwnedChildCountRenderer>.NativeClassPtr, 100664774);
			OwnedChildCountRenderer.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OwnedChildCountRenderer>.NativeClassPtr, 100664775);
			OwnedChildCountRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OwnedChildCountRenderer>.NativeClassPtr, 100664776);
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00038B40 File Offset: 0x00036D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701887, XrefRangeEnd = 701894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OwnedChildCountRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00038B7C File Offset: 0x00036D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701894, XrefRangeEnd = 701899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForOwner()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OwnedChildCountRenderer.NativeMethodInfoPtr_WaitForOwner_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00038BBC File Offset: 0x00036DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701899, XrefRangeEnd = 701917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OwnedChildCountRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00038BF8 File Offset: 0x00036DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701917, XrefRangeEnd = 701923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OwnedChildCountRenderer.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00038C2C File Offset: 0x00036E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701923, XrefRangeEnd = 701929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OwnedChildCountRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OwnedChildCountRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OwnedChildCountRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x00007971 File Offset: 0x00005B71
		public OwnedChildCountRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x00038C68 File Offset: 0x00036E68
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x0000797A File Offset: 0x00005B7A
		public unsafe EntityView ownerView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnedChildCountRenderer.NativeFieldInfoPtr_ownerView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnedChildCountRenderer.NativeFieldInfoPtr_ownerView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00038C98 File Offset: 0x00036E98
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x00007999 File Offset: 0x00005B99
		public unsafe TMP_Text countText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnedChildCountRenderer.NativeFieldInfoPtr_countText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnedChildCountRenderer.NativeFieldInfoPtr_countText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x00038CC8 File Offset: 0x00036EC8
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x000079B8 File Offset: 0x00005BB8
		public unsafe BoolUnityEvents onIsEmpty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnedChildCountRenderer.NativeFieldInfoPtr_onIsEmpty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnedChildCountRenderer.NativeFieldInfoPtr_onIsEmpty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeFieldInfoPtr_ownerView;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeFieldInfoPtr_countText;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeFieldInfoPtr_onIsEmpty;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr_WaitForOwner_Private_IEnumerator_0;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000354 RID: 852
		[ObfuscatedName("worm.match.dataRenderers.OwnedChildCountRenderer+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06002273 RID: 8819 RVA: 0x00080CA0 File Offset: 0x0007EEA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<OwnedChildCountRenderer.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OwnedChildCountRenderer>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OwnedChildCountRenderer.__c__DisplayClass5_0>.NativeClassPtr);
				OwnedChildCountRenderer.__c__DisplayClass5_0.NativeFieldInfoPtr_ownerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OwnedChildCountRenderer.__c__DisplayClass5_0>.NativeClassPtr, "ownerID");
				OwnedChildCountRenderer.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OwnedChildCountRenderer.__c__DisplayClass5_0>.NativeClassPtr, 100664777);
				OwnedChildCountRenderer.__c__DisplayClass5_0.NativeMethodInfoPtr__DirtyUpdate_b__0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OwnedChildCountRenderer.__c__DisplayClass5_0>.NativeClassPtr, 100664778);
			}

			// Token: 0x06002274 RID: 8820 RVA: 0x00080D08 File Offset: 0x0007EF08
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OwnedChildCountRenderer.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OwnedChildCountRenderer.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002275 RID: 8821 RVA: 0x00080D44 File Offset: 0x0007EF44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701876, XrefRangeEnd = 701881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DirtyUpdate_b__0(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OwnedChildCountRenderer.__c__DisplayClass5_0.NativeMethodInfoPtr__DirtyUpdate_b__0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002276 RID: 8822 RVA: 0x000134E8 File Offset: 0x000116E8
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000982 RID: 2434
			// (get) Token: 0x06002277 RID: 8823 RVA: 0x00080D94 File Offset: 0x0007EF94
			// (set) Token: 0x06002278 RID: 8824 RVA: 0x000134F1 File Offset: 0x000116F1
			public unsafe AccountID ownerID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnedChildCountRenderer.__c__DisplayClass5_0.NativeFieldInfoPtr_ownerID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnedChildCountRenderer.__c__DisplayClass5_0.NativeFieldInfoPtr_ownerID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013D3 RID: 5075
			private static readonly IntPtr NativeFieldInfoPtr_ownerID;

			// Token: 0x040013D4 RID: 5076
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013D5 RID: 5077
			private static readonly IntPtr NativeMethodInfoPtr__DirtyUpdate_b__0_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000355 RID: 853
		[ObfuscatedName("worm.match.dataRenderers.OwnedChildCountRenderer+<WaitForOwner>d__4")]
		public sealed class _WaitForOwner_d__4 : Object
		{
			// Token: 0x06002279 RID: 8825 RVA: 0x00080DC4 File Offset: 0x0007EFC4
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForOwner_d__4()
			{
				Il2CppClassPointerStore<OwnedChildCountRenderer._WaitForOwner_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OwnedChildCountRenderer>.NativeClassPtr, "<WaitForOwner>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OwnedChildCountRenderer._WaitForOwner_d__4>.NativeClassPtr);
				OwnedChildCountRenderer._WaitForOwner_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OwnedChildCountRenderer._WaitForOwner_d__4>.NativeClassPtr, "<>1__state");
				OwnedChildCountRenderer._WaitForOwner_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OwnedChildCountRenderer._WaitForOwner_d__4>.NativeClassPtr, "<>2__current");
				OwnedChildCountRenderer._WaitForOwner_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OwnedChildCountRenderer._WaitForOwner_d__4>.NativeClassPtr, "<>4__this");
				OwnedChildCountRenderer._WaitForOwner_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OwnedChildCountRenderer._WaitForOwner_d__4>.NativeClassPtr, 100664779);
				OwnedChildCountRenderer._WaitForOwner_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OwnedChildCountRenderer._WaitForOwner_d__4>.NativeClassPtr, 100664780);
				OwnedChildCountRenderer._WaitForOwner_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OwnedChildCountRenderer._WaitForOwner_d__4>.NativeClassPtr, 100664781);
				OwnedChildCountRenderer._WaitForOwner_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OwnedChildCountRenderer._WaitForOwner_d__4>.NativeClassPtr, 100664782);
				OwnedChildCountRenderer._WaitForOwner_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OwnedChildCountRenderer._WaitForOwner_d__4>.NativeClassPtr, 100664783);
				OwnedChildCountRenderer._WaitForOwner_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OwnedChildCountRenderer._WaitForOwner_d__4>.NativeClassPtr, 100664784);
			}

			// Token: 0x0600227A RID: 8826 RVA: 0x00080EA4 File Offset: 0x0007F0A4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WaitForOwner_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OwnedChildCountRenderer._WaitForOwner_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OwnedChildCountRenderer._WaitForOwner_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600227B RID: 8827 RVA: 0x00080EEC File Offset: 0x0007F0EC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OwnedChildCountRenderer._WaitForOwner_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600227C RID: 8828 RVA: 0x00080F20 File Offset: 0x0007F120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701881, XrefRangeEnd = 701882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OwnedChildCountRenderer._WaitForOwner_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000986 RID: 2438
			// (get) Token: 0x0600227D RID: 8829 RVA: 0x00080F5C File Offset: 0x0007F15C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OwnedChildCountRenderer._WaitForOwner_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600227E RID: 8830 RVA: 0x00080F9C File Offset: 0x0007F19C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701882, XrefRangeEnd = 701887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OwnedChildCountRenderer._WaitForOwner_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000987 RID: 2439
			// (get) Token: 0x0600227F RID: 8831 RVA: 0x00080FD0 File Offset: 0x0007F1D0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OwnedChildCountRenderer._WaitForOwner_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002280 RID: 8832 RVA: 0x00013510 File Offset: 0x00011710
			public _WaitForOwner_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000983 RID: 2435
			// (get) Token: 0x06002281 RID: 8833 RVA: 0x00081010 File Offset: 0x0007F210
			// (set) Token: 0x06002282 RID: 8834 RVA: 0x00013519 File Offset: 0x00011719
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnedChildCountRenderer._WaitForOwner_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnedChildCountRenderer._WaitForOwner_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000984 RID: 2436
			// (get) Token: 0x06002283 RID: 8835 RVA: 0x00081038 File Offset: 0x0007F238
			// (set) Token: 0x06002284 RID: 8836 RVA: 0x00013534 File Offset: 0x00011734
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnedChildCountRenderer._WaitForOwner_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnedChildCountRenderer._WaitForOwner_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000985 RID: 2437
			// (get) Token: 0x06002285 RID: 8837 RVA: 0x00081068 File Offset: 0x0007F268
			// (set) Token: 0x06002286 RID: 8838 RVA: 0x00013553 File Offset: 0x00011753
			public unsafe OwnedChildCountRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnedChildCountRenderer._WaitForOwner_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OwnedChildCountRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnedChildCountRenderer._WaitForOwner_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013D6 RID: 5078
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040013D7 RID: 5079
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040013D8 RID: 5080
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040013D9 RID: 5081
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040013DA RID: 5082
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040013DB RID: 5083
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040013DC RID: 5084
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040013DD RID: 5085
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040013DE RID: 5086
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
