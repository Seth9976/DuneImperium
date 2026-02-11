using System;
using boardgames.match.behaviours;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine;

// Token: 0x0200001D RID: 29
public class WormHighlightControlSpaceRenderer : Observer
{
	// Token: 0x06000112 RID: 274 RVA: 0x0001C0A0 File Offset: 0x0001A2A0
	// Note: this type is marked as 'beforefieldinit'.
	static WormHighlightControlSpaceRenderer()
	{
		Il2CppClassPointerStore<WormHighlightControlSpaceRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormHighlightControlSpaceRenderer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer>.NativeClassPtr);
		WormHighlightControlSpaceRenderer.NativeFieldInfoPtr_highlightAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer>.NativeClassPtr, "highlightAnim");
		WormHighlightControlSpaceRenderer.NativeFieldInfoPtr_myID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer>.NativeClassPtr, "myID");
		WormHighlightControlSpaceRenderer.NativeFieldInfoPtr_BannerHintOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer>.NativeClassPtr, "BannerHintOn");
		WormHighlightControlSpaceRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer>.NativeClassPtr, 100663452);
		WormHighlightControlSpaceRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer>.NativeClassPtr, 100663453);
		WormHighlightControlSpaceRenderer.NativeMethodInfoPtr_Initialize_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer>.NativeClassPtr, 100663454);
		WormHighlightControlSpaceRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer>.NativeClassPtr, 100663455);
	}

	// Token: 0x06000113 RID: 275 RVA: 0x0001C15C File Offset: 0x0001A35C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687879, XrefRangeEnd = 687891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHighlightControlSpaceRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000114 RID: 276 RVA: 0x0001C198 File Offset: 0x0001A398
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687891, XrefRangeEnd = 687919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void DirtyUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHighlightControlSpaceRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000115 RID: 277 RVA: 0x0001C1D4 File Offset: 0x0001A3D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687919, XrefRangeEnd = 687924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHighlightControlSpaceRenderer.NativeMethodInfoPtr_Initialize_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000116 RID: 278 RVA: 0x0001C214 File Offset: 0x0001A414
	[CallerCount(197)]
	[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormHighlightControlSpaceRenderer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHighlightControlSpaceRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000117 RID: 279 RVA: 0x0000285B File Offset: 0x00000A5B
	public WormHighlightControlSpaceRenderer(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x06000118 RID: 280 RVA: 0x0001C250 File Offset: 0x0001A450
	// (set) Token: 0x06000119 RID: 281 RVA: 0x00002864 File Offset: 0x00000A64
	public unsafe Animator highlightAnim
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighlightControlSpaceRenderer.NativeFieldInfoPtr_highlightAnim);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighlightControlSpaceRenderer.NativeFieldInfoPtr_highlightAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x0600011A RID: 282 RVA: 0x0001C280 File Offset: 0x0001A480
	// (set) Token: 0x0600011B RID: 283 RVA: 0x00002883 File Offset: 0x00000A83
	public unsafe ArchetypeID myID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighlightControlSpaceRenderer.NativeFieldInfoPtr_myID);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighlightControlSpaceRenderer.NativeFieldInfoPtr_myID), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x0600011C RID: 284 RVA: 0x0001C2B0 File Offset: 0x0001A4B0
	// (set) Token: 0x0600011D RID: 285 RVA: 0x000028A2 File Offset: 0x00000AA2
	public unsafe static int BannerHintOn
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(WormHighlightControlSpaceRenderer.NativeFieldInfoPtr_BannerHintOn, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WormHighlightControlSpaceRenderer.NativeFieldInfoPtr_BannerHintOn, (void*)(&value));
		}
	}

	// Token: 0x040000A2 RID: 162
	private static readonly IntPtr NativeFieldInfoPtr_highlightAnim;

	// Token: 0x040000A3 RID: 163
	private static readonly IntPtr NativeFieldInfoPtr_myID;

	// Token: 0x040000A4 RID: 164
	private static readonly IntPtr NativeFieldInfoPtr_BannerHintOn;

	// Token: 0x040000A5 RID: 165
	private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

	// Token: 0x040000A6 RID: 166
	private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

	// Token: 0x040000A7 RID: 167
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_IEnumerator_0;

	// Token: 0x040000A8 RID: 168
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020002B7 RID: 695
	[ObfuscatedName("WormHighlightControlSpaceRenderer+<Initialize>d__5")]
	public sealed class _Initialize_d__5 : global::Il2CppSystem.Object
	{
		// Token: 0x06001C59 RID: 7257 RVA: 0x0006F354 File Offset: 0x0006D554
		// Note: this type is marked as 'beforefieldinit'.
		static _Initialize_d__5()
		{
			Il2CppClassPointerStore<WormHighlightControlSpaceRenderer._Initialize_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer>.NativeClassPtr, "<Initialize>d__5");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer._Initialize_d__5>.NativeClassPtr);
			WormHighlightControlSpaceRenderer._Initialize_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer._Initialize_d__5>.NativeClassPtr, "<>1__state");
			WormHighlightControlSpaceRenderer._Initialize_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer._Initialize_d__5>.NativeClassPtr, "<>2__current");
			WormHighlightControlSpaceRenderer._Initialize_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer._Initialize_d__5>.NativeClassPtr, "<>4__this");
			WormHighlightControlSpaceRenderer._Initialize_d__5.NativeFieldInfoPtr__provider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer._Initialize_d__5>.NativeClassPtr, "<provider>5__2");
			WormHighlightControlSpaceRenderer._Initialize_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer._Initialize_d__5>.NativeClassPtr, 100663457);
			WormHighlightControlSpaceRenderer._Initialize_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer._Initialize_d__5>.NativeClassPtr, 100663458);
			WormHighlightControlSpaceRenderer._Initialize_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer._Initialize_d__5>.NativeClassPtr, 100663459);
			WormHighlightControlSpaceRenderer._Initialize_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer._Initialize_d__5>.NativeClassPtr, 100663460);
			WormHighlightControlSpaceRenderer._Initialize_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer._Initialize_d__5>.NativeClassPtr, 100663461);
			WormHighlightControlSpaceRenderer._Initialize_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer._Initialize_d__5>.NativeClassPtr, 100663462);
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x0006F448 File Offset: 0x0006D648
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Initialize_d__5(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHighlightControlSpaceRenderer._Initialize_d__5>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHighlightControlSpaceRenderer._Initialize_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x0006F490 File Offset: 0x0006D690
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHighlightControlSpaceRenderer._Initialize_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x0006F4C4 File Offset: 0x0006D6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687839, XrefRangeEnd = 687874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHighlightControlSpaceRenderer._Initialize_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001C5D RID: 7261 RVA: 0x0006F500 File Offset: 0x0006D700
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHighlightControlSpaceRenderer._Initialize_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x0006F540 File Offset: 0x0006D740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687874, XrefRangeEnd = 687879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHighlightControlSpaceRenderer._Initialize_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x0006F574 File Offset: 0x0006D774
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHighlightControlSpaceRenderer._Initialize_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x00010483 File Offset: 0x0000E683
		public _Initialize_d__5(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x0006F5B4 File Offset: 0x0006D7B4
		// (set) Token: 0x06001C62 RID: 7266 RVA: 0x0001048C File Offset: 0x0000E68C
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighlightControlSpaceRenderer._Initialize_d__5.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighlightControlSpaceRenderer._Initialize_d__5.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x0006F5DC File Offset: 0x0006D7DC
		// (set) Token: 0x06001C64 RID: 7268 RVA: 0x000104A7 File Offset: 0x0000E6A7
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighlightControlSpaceRenderer._Initialize_d__5.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighlightControlSpaceRenderer._Initialize_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x0006F60C File Offset: 0x0006D80C
		// (set) Token: 0x06001C66 RID: 7270 RVA: 0x000104C6 File Offset: 0x0000E6C6
		public unsafe WormHighlightControlSpaceRenderer __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighlightControlSpaceRenderer._Initialize_d__5.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormHighlightControlSpaceRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighlightControlSpaceRenderer._Initialize_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x0006F63C File Offset: 0x0006D83C
		// (set) Token: 0x06001C68 RID: 7272 RVA: 0x000104E5 File Offset: 0x0000E6E5
		public unsafe DBGEntitiesProvider _provider_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighlightControlSpaceRenderer._Initialize_d__5.NativeFieldInfoPtr__provider_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHighlightControlSpaceRenderer._Initialize_d__5.NativeFieldInfoPtr__provider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeFieldInfoPtr__provider_5__2;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
