using System;
using boardgames.match.behaviours;
using boardgames.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using TMPro;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000111 RID: 273
	public class WormDeployedStrengthRenderer : VersionedView<WormStrengthData>
	{
		// Token: 0x06000C5F RID: 3167 RVA: 0x0003DB18 File Offset: 0x0003BD18
		// Note: this type is marked as 'beforefieldinit'.
		static WormDeployedStrengthRenderer()
		{
			Il2CppClassPointerStore<WormDeployedStrengthRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormDeployedStrengthRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDeployedStrengthRenderer>.NativeClassPtr);
			WormDeployedStrengthRenderer.NativeFieldInfoPtr_textComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedStrengthRenderer>.NativeClassPtr, "textComponent");
			WormDeployedStrengthRenderer.NativeFieldInfoPtr_troopsRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedStrengthRenderer>.NativeClassPtr, "troopsRenderer");
			WormDeployedStrengthRenderer.NativeFieldInfoPtr_lastPickerKind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedStrengthRenderer>.NativeClassPtr, "lastPickerKind");
			WormDeployedStrengthRenderer.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedStrengthRenderer>.NativeClassPtr, "selectionResponder");
			WormDeployedStrengthRenderer.NativeFieldInfoPtr_cachedDeployCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedStrengthRenderer>.NativeClassPtr, "cachedDeployCount");
			WormDeployedStrengthRenderer.NativeFieldInfoPtr_cachedDeployDNCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedStrengthRenderer>.NativeClassPtr, "cachedDeployDNCount");
			WormDeployedStrengthRenderer.NativeFieldInfoPtr_dreadnoughtStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedStrengthRenderer>.NativeClassPtr, "dreadnoughtStrength");
			WormDeployedStrengthRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedStrengthRenderer>.NativeClassPtr, 100665009);
			WormDeployedStrengthRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedStrengthRenderer>.NativeClassPtr, 100665010);
			WormDeployedStrengthRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedStrengthRenderer>.NativeClassPtr, 100665011);
			WormDeployedStrengthRenderer.NativeMethodInfoPtr_UpdatedCachedDeployCount_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedStrengthRenderer>.NativeClassPtr, 100665012);
			WormDeployedStrengthRenderer.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedStrengthRenderer>.NativeClassPtr, 100665013);
			WormDeployedStrengthRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedStrengthRenderer>.NativeClassPtr, 100665014);
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0003DC4C File Offset: 0x0003BE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704379, XrefRangeEnd = 704388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDeployedStrengthRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0003DC88 File Offset: 0x0003BE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704388, XrefRangeEnd = 704393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedStrengthRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0003DCC8 File Offset: 0x0003BEC8
		[CallerCount(0)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDeployedStrengthRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0003DD04 File Offset: 0x0003BF04
		[CallerCount(0)]
		public unsafe void UpdatedCachedDeployCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedStrengthRenderer.NativeMethodInfoPtr_UpdatedCachedDeployCount_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x0003DD38 File Offset: 0x0003BF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704393, XrefRangeEnd = 704406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDeployedStrengthRenderer.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0003DD74 File Offset: 0x0003BF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704406, XrefRangeEnd = 704412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDeployedStrengthRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDeployedStrengthRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedStrengthRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x00008832 File Offset: 0x00006A32
		public WormDeployedStrengthRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x0003DDB0 File Offset: 0x0003BFB0
		// (set) Token: 0x06000C68 RID: 3176 RVA: 0x0000883B File Offset: 0x00006A3B
		public unsafe TMP_Text textComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer.NativeFieldInfoPtr_textComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer.NativeFieldInfoPtr_textComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x0003DDE0 File Offset: 0x0003BFE0
		// (set) Token: 0x06000C6A RID: 3178 RVA: 0x0000885A File Offset: 0x00006A5A
		public unsafe WormDeployedTroopsRenderer troopsRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer.NativeFieldInfoPtr_troopsRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormDeployedTroopsRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer.NativeFieldInfoPtr_troopsRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x0003DE10 File Offset: 0x0003C010
		// (set) Token: 0x06000C6C RID: 3180 RVA: 0x00008879 File Offset: 0x00006A79
		public unsafe string lastPickerKind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer.NativeFieldInfoPtr_lastPickerKind);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer.NativeFieldInfoPtr_lastPickerKind), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x0003DE38 File Offset: 0x0003C038
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x00008898 File Offset: 0x00006A98
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x0003DE68 File Offset: 0x0003C068
		// (set) Token: 0x06000C70 RID: 3184 RVA: 0x000088B7 File Offset: 0x00006AB7
		public unsafe int cachedDeployCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer.NativeFieldInfoPtr_cachedDeployCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer.NativeFieldInfoPtr_cachedDeployCount)) = value;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x0003DE90 File Offset: 0x0003C090
		// (set) Token: 0x06000C72 RID: 3186 RVA: 0x000088D2 File Offset: 0x00006AD2
		public unsafe int cachedDeployDNCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer.NativeFieldInfoPtr_cachedDeployDNCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer.NativeFieldInfoPtr_cachedDeployDNCount)) = value;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x0003DEB8 File Offset: 0x0003C0B8
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x000088ED File Offset: 0x00006AED
		public unsafe int dreadnoughtStrength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer.NativeFieldInfoPtr_dreadnoughtStrength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer.NativeFieldInfoPtr_dreadnoughtStrength)) = value;
			}
		}

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeFieldInfoPtr_textComponent;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeFieldInfoPtr_troopsRenderer;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeFieldInfoPtr_lastPickerKind;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeFieldInfoPtr_cachedDeployCount;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeFieldInfoPtr_cachedDeployDNCount;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeFieldInfoPtr_dreadnoughtStrength;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeMethodInfoPtr_UpdatedCachedDeployCount_Private_Void_0;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000375 RID: 885
		[ObfuscatedName("worm.match.dataRenderers.WormDeployedStrengthRenderer+<Init>d__8")]
		public sealed class _Init_d__8 : Object
		{
			// Token: 0x0600239E RID: 9118 RVA: 0x00084278 File Offset: 0x00082478
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__8()
			{
				Il2CppClassPointerStore<WormDeployedStrengthRenderer._Init_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormDeployedStrengthRenderer>.NativeClassPtr, "<Init>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDeployedStrengthRenderer._Init_d__8>.NativeClassPtr);
				WormDeployedStrengthRenderer._Init_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedStrengthRenderer._Init_d__8>.NativeClassPtr, "<>1__state");
				WormDeployedStrengthRenderer._Init_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedStrengthRenderer._Init_d__8>.NativeClassPtr, "<>2__current");
				WormDeployedStrengthRenderer._Init_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedStrengthRenderer._Init_d__8>.NativeClassPtr, "<>4__this");
				WormDeployedStrengthRenderer._Init_d__8.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedStrengthRenderer._Init_d__8>.NativeClassPtr, "<entitiesProvider>5__2");
				WormDeployedStrengthRenderer._Init_d__8.NativeFieldInfoPtr__entities_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedStrengthRenderer._Init_d__8>.NativeClassPtr, "<entities>5__3");
				WormDeployedStrengthRenderer._Init_d__8.NativeFieldInfoPtr__parent_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedStrengthRenderer._Init_d__8>.NativeClassPtr, "<parent>5__4");
				WormDeployedStrengthRenderer._Init_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedStrengthRenderer._Init_d__8>.NativeClassPtr, 100665015);
				WormDeployedStrengthRenderer._Init_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedStrengthRenderer._Init_d__8>.NativeClassPtr, 100665016);
				WormDeployedStrengthRenderer._Init_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedStrengthRenderer._Init_d__8>.NativeClassPtr, 100665017);
				WormDeployedStrengthRenderer._Init_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedStrengthRenderer._Init_d__8>.NativeClassPtr, 100665018);
				WormDeployedStrengthRenderer._Init_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedStrengthRenderer._Init_d__8>.NativeClassPtr, 100665019);
				WormDeployedStrengthRenderer._Init_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedStrengthRenderer._Init_d__8>.NativeClassPtr, 100665020);
			}

			// Token: 0x0600239F RID: 9119 RVA: 0x00084394 File Offset: 0x00082594
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDeployedStrengthRenderer._Init_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedStrengthRenderer._Init_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023A0 RID: 9120 RVA: 0x000843DC File Offset: 0x000825DC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedStrengthRenderer._Init_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023A1 RID: 9121 RVA: 0x00084410 File Offset: 0x00082610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704341, XrefRangeEnd = 704374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedStrengthRenderer._Init_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170009DA RID: 2522
			// (get) Token: 0x060023A2 RID: 9122 RVA: 0x0008444C File Offset: 0x0008264C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedStrengthRenderer._Init_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060023A3 RID: 9123 RVA: 0x0008448C File Offset: 0x0008268C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704374, XrefRangeEnd = 704379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedStrengthRenderer._Init_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009DB RID: 2523
			// (get) Token: 0x060023A4 RID: 9124 RVA: 0x000844C0 File Offset: 0x000826C0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedStrengthRenderer._Init_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060023A5 RID: 9125 RVA: 0x00013DDE File Offset: 0x00011FDE
			public _Init_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009D4 RID: 2516
			// (get) Token: 0x060023A6 RID: 9126 RVA: 0x00084500 File Offset: 0x00082700
			// (set) Token: 0x060023A7 RID: 9127 RVA: 0x00013DE7 File Offset: 0x00011FE7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer._Init_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer._Init_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009D5 RID: 2517
			// (get) Token: 0x060023A8 RID: 9128 RVA: 0x00084528 File Offset: 0x00082728
			// (set) Token: 0x060023A9 RID: 9129 RVA: 0x00013E02 File Offset: 0x00012002
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer._Init_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer._Init_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009D6 RID: 2518
			// (get) Token: 0x060023AA RID: 9130 RVA: 0x00084558 File Offset: 0x00082758
			// (set) Token: 0x060023AB RID: 9131 RVA: 0x00013E21 File Offset: 0x00012021
			public unsafe WormDeployedStrengthRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer._Init_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormDeployedStrengthRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer._Init_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009D7 RID: 2519
			// (get) Token: 0x060023AC RID: 9132 RVA: 0x00084588 File Offset: 0x00082788
			// (set) Token: 0x060023AD RID: 9133 RVA: 0x00013E40 File Offset: 0x00012040
			public unsafe DBGEntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer._Init_d__8.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer._Init_d__8.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009D8 RID: 2520
			// (get) Token: 0x060023AE RID: 9134 RVA: 0x000845B8 File Offset: 0x000827B8
			// (set) Token: 0x060023AF RID: 9135 RVA: 0x00013E5F File Offset: 0x0001205F
			public unsafe WormEntities _entities_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer._Init_d__8.NativeFieldInfoPtr__entities_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntities>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer._Init_d__8.NativeFieldInfoPtr__entities_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009D9 RID: 2521
			// (get) Token: 0x060023B0 RID: 9136 RVA: 0x000845E8 File Offset: 0x000827E8
			// (set) Token: 0x060023B1 RID: 9137 RVA: 0x00013E7E File Offset: 0x0001207E
			public unsafe EntityView _parent_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer._Init_d__8.NativeFieldInfoPtr__parent_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedStrengthRenderer._Init_d__8.NativeFieldInfoPtr__parent_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001474 RID: 5236
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001475 RID: 5237
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001476 RID: 5238
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001477 RID: 5239
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x04001478 RID: 5240
			private static readonly IntPtr NativeFieldInfoPtr__entities_5__3;

			// Token: 0x04001479 RID: 5241
			private static readonly IntPtr NativeFieldInfoPtr__parent_5__4;

			// Token: 0x0400147A RID: 5242
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400147B RID: 5243
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400147C RID: 5244
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400147D RID: 5245
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400147E RID: 5246
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400147F RID: 5247
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
