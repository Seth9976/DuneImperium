using System;
using boardgames.match.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using voodoo;

// Token: 0x0200001E RID: 30
public class WormSwordsmasterSlotEnableRenderer : VersionedDataComponentObserver<WormSwordsmasterData>
{
	// Token: 0x0600011E RID: 286 RVA: 0x0001C2CC File Offset: 0x0001A4CC
	// Note: this type is marked as 'beforefieldinit'.
	static WormSwordsmasterSlotEnableRenderer()
	{
		Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormSwordsmasterSlotEnableRenderer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer>.NativeClassPtr);
		WormSwordsmasterSlotEnableRenderer.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer>.NativeClassPtr, "root");
		WormSwordsmasterSlotEnableRenderer.NativeFieldInfoPtr_hideInScenarios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer>.NativeClassPtr, "hideInScenarios");
		WormSwordsmasterSlotEnableRenderer.NativeFieldInfoPtr_forceHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer>.NativeClassPtr, "forceHide");
		WormSwordsmasterSlotEnableRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer>.NativeClassPtr, 100663463);
		WormSwordsmasterSlotEnableRenderer.NativeMethodInfoPtr_init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer>.NativeClassPtr, 100663464);
		WormSwordsmasterSlotEnableRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer>.NativeClassPtr, 100663465);
		WormSwordsmasterSlotEnableRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer>.NativeClassPtr, 100663466);
	}

	// Token: 0x0600011F RID: 287 RVA: 0x0001C388 File Offset: 0x0001A588
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687938, XrefRangeEnd = 687945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSwordsmasterSlotEnableRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000120 RID: 288 RVA: 0x0001C3C4 File Offset: 0x0001A5C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687945, XrefRangeEnd = 687950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSwordsmasterSlotEnableRenderer.NativeMethodInfoPtr_init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000121 RID: 289 RVA: 0x0001C404 File Offset: 0x0001A604
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687950, XrefRangeEnd = 687956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void versionChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSwordsmasterSlotEnableRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000122 RID: 290 RVA: 0x0001C440 File Offset: 0x0001A640
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687956, XrefRangeEnd = 687963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormSwordsmasterSlotEnableRenderer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSwordsmasterSlotEnableRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000123 RID: 291 RVA: 0x000028B0 File Offset: 0x00000AB0
	public WormSwordsmasterSlotEnableRenderer(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06000124 RID: 292 RVA: 0x0001C47C File Offset: 0x0001A67C
	// (set) Token: 0x06000125 RID: 293 RVA: 0x000028B9 File Offset: 0x00000AB9
	public unsafe GameObject root
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSwordsmasterSlotEnableRenderer.NativeFieldInfoPtr_root);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSwordsmasterSlotEnableRenderer.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x06000126 RID: 294 RVA: 0x0001C4AC File Offset: 0x0001A6AC
	// (set) Token: 0x06000127 RID: 295 RVA: 0x000028D8 File Offset: 0x00000AD8
	public unsafe Il2CppStringArray hideInScenarios
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSwordsmasterSlotEnableRenderer.NativeFieldInfoPtr_hideInScenarios);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSwordsmasterSlotEnableRenderer.NativeFieldInfoPtr_hideInScenarios), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x06000128 RID: 296 RVA: 0x0001C4DC File Offset: 0x0001A6DC
	// (set) Token: 0x06000129 RID: 297 RVA: 0x000028F7 File Offset: 0x00000AF7
	public unsafe bool forceHide
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSwordsmasterSlotEnableRenderer.NativeFieldInfoPtr_forceHide);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSwordsmasterSlotEnableRenderer.NativeFieldInfoPtr_forceHide)) = value;
		}
	}

	// Token: 0x040000A9 RID: 169
	private static readonly IntPtr NativeFieldInfoPtr_root;

	// Token: 0x040000AA RID: 170
	private static readonly IntPtr NativeFieldInfoPtr_hideInScenarios;

	// Token: 0x040000AB RID: 171
	private static readonly IntPtr NativeFieldInfoPtr_forceHide;

	// Token: 0x040000AC RID: 172
	private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

	// Token: 0x040000AD RID: 173
	private static readonly IntPtr NativeMethodInfoPtr_init_Private_IEnumerator_0;

	// Token: 0x040000AE RID: 174
	private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

	// Token: 0x040000AF RID: 175
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020002B8 RID: 696
	[ObfuscatedName("WormSwordsmasterSlotEnableRenderer+<init>d__4")]
	public sealed class _init_d__4 : global::Il2CppSystem.Object
	{
		// Token: 0x06001C69 RID: 7273 RVA: 0x0006F66C File Offset: 0x0006D86C
		// Note: this type is marked as 'beforefieldinit'.
		static _init_d__4()
		{
			Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer._init_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer>.NativeClassPtr, "<init>d__4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer._init_d__4>.NativeClassPtr);
			WormSwordsmasterSlotEnableRenderer._init_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer._init_d__4>.NativeClassPtr, "<>1__state");
			WormSwordsmasterSlotEnableRenderer._init_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer._init_d__4>.NativeClassPtr, "<>2__current");
			WormSwordsmasterSlotEnableRenderer._init_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer._init_d__4>.NativeClassPtr, "<>4__this");
			WormSwordsmasterSlotEnableRenderer._init_d__4.NativeFieldInfoPtr__matchHub_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer._init_d__4>.NativeClassPtr, "<matchHub>5__2");
			WormSwordsmasterSlotEnableRenderer._init_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer._init_d__4>.NativeClassPtr, 100663467);
			WormSwordsmasterSlotEnableRenderer._init_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer._init_d__4>.NativeClassPtr, 100663468);
			WormSwordsmasterSlotEnableRenderer._init_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer._init_d__4>.NativeClassPtr, 100663469);
			WormSwordsmasterSlotEnableRenderer._init_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer._init_d__4>.NativeClassPtr, 100663470);
			WormSwordsmasterSlotEnableRenderer._init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer._init_d__4>.NativeClassPtr, 100663471);
			WormSwordsmasterSlotEnableRenderer._init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer._init_d__4>.NativeClassPtr, 100663472);
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x0006F760 File Offset: 0x0006D960
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _init_d__4(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSwordsmasterSlotEnableRenderer._init_d__4>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSwordsmasterSlotEnableRenderer._init_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x0006F7A8 File Offset: 0x0006D9A8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSwordsmasterSlotEnableRenderer._init_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x0006F7DC File Offset: 0x0006D9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687924, XrefRangeEnd = 687933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSwordsmasterSlotEnableRenderer._init_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001C6D RID: 7277 RVA: 0x0006F818 File Offset: 0x0006DA18
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSwordsmasterSlotEnableRenderer._init_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x0006F858 File Offset: 0x0006DA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687933, XrefRangeEnd = 687938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSwordsmasterSlotEnableRenderer._init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001C6F RID: 7279 RVA: 0x0006F88C File Offset: 0x0006DA8C
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSwordsmasterSlotEnableRenderer._init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x00010504 File Offset: 0x0000E704
		public _init_d__4(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x0006F8CC File Offset: 0x0006DACC
		// (set) Token: 0x06001C72 RID: 7282 RVA: 0x0001050D File Offset: 0x0000E70D
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSwordsmasterSlotEnableRenderer._init_d__4.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSwordsmasterSlotEnableRenderer._init_d__4.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x0006F8F4 File Offset: 0x0006DAF4
		// (set) Token: 0x06001C74 RID: 7284 RVA: 0x00010528 File Offset: 0x0000E728
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSwordsmasterSlotEnableRenderer._init_d__4.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSwordsmasterSlotEnableRenderer._init_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x0006F924 File Offset: 0x0006DB24
		// (set) Token: 0x06001C76 RID: 7286 RVA: 0x00010547 File Offset: 0x0000E747
		public unsafe WormSwordsmasterSlotEnableRenderer __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSwordsmasterSlotEnableRenderer._init_d__4.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSwordsmasterSlotEnableRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSwordsmasterSlotEnableRenderer._init_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x0006F954 File Offset: 0x0006DB54
		// (set) Token: 0x06001C78 RID: 7288 RVA: 0x00010566 File Offset: 0x0000E766
		public unsafe DBGMatchHub _matchHub_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSwordsmasterSlotEnableRenderer._init_d__4.NativeFieldInfoPtr__matchHub_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGMatchHub>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSwordsmasterSlotEnableRenderer._init_d__4.NativeFieldInfoPtr__matchHub_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeFieldInfoPtr__matchHub_5__2;

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
