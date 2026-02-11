using System;
using boardgames.utils;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompters;
using dwd.core.ui.prompt.prompts;
using dwd.iap.store;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

// Token: 0x02000026 RID: 38
public class WormTutorialFTTFlow : Command
{
	// Token: 0x06000185 RID: 389 RVA: 0x0001D9F4 File Offset: 0x0001BBF4
	// Note: this type is marked as 'beforefieldinit'.
	static WormTutorialFTTFlow()
	{
		Il2CppClassPointerStore<WormTutorialFTTFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormTutorialFTTFlow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialFTTFlow>.NativeClassPtr);
		WormTutorialFTTFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialFTTFlow>.NativeClassPtr, 100663544);
		WormTutorialFTTFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialFTTFlow>.NativeClassPtr, 100663545);
	}

	// Token: 0x06000186 RID: 390 RVA: 0x0001DA4C File Offset: 0x0001BC4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689302, XrefRangeEnd = 689306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IEnumerator execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTutorialFTTFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000187 RID: 391 RVA: 0x0001DA98 File Offset: 0x0001BC98
	[CallerCount(55)]
	[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormTutorialFTTFlow()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialFTTFlow>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialFTTFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00002B28 File Offset: 0x00000D28
	public WormTutorialFTTFlow(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x040000ED RID: 237
	private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

	// Token: 0x040000EE RID: 238
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020002C2 RID: 706
	[ObfuscatedName("WormTutorialFTTFlow+<>c__DisplayClass0_0")]
	public sealed class __c__DisplayClass0_0 : Object
	{
		// Token: 0x06001CC1 RID: 7361 RVA: 0x000706EC File Offset: 0x0006E8EC
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass0_0()
		{
			Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialFTTFlow>.NativeClassPtr, "<>c__DisplayClass0_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_0>.NativeClassPtr);
			WormTutorialFTTFlow.__c__DisplayClass0_0.NativeFieldInfoPtr_iapStoreBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_0>.NativeClassPtr, "iapStoreBehaviour");
			WormTutorialFTTFlow.__c__DisplayClass0_0.NativeFieldInfoPtr_productUtils = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_0>.NativeClassPtr, "productUtils");
			WormTutorialFTTFlow.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_0>.NativeClassPtr, 100663546);
			WormTutorialFTTFlow.__c__DisplayClass0_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_0>.NativeClassPtr, 100663547);
			WormTutorialFTTFlow.__c__DisplayClass0_0.NativeMethodInfoPtr__execute_b__1_Internal_Boolean_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_0>.NativeClassPtr, 100663548);
			WormTutorialFTTFlow.__c__DisplayClass0_0.NativeMethodInfoPtr_Method_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_0>.NativeClassPtr, 100663549);
			WormTutorialFTTFlow.__c__DisplayClass0_0.NativeMethodInfoPtr_Method_Internal_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_0>.NativeClassPtr, 100663550);
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x000707A4 File Offset: 0x0006E9A4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass0_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialFTTFlow.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x000707E0 File Offset: 0x0006E9E0
		[CallerCount(0)]
		public unsafe bool _execute_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialFTTFlow.__c__DisplayClass0_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x0007081C File Offset: 0x0006EA1C
		[CallerCount(0)]
		public unsafe bool _execute_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialFTTFlow.__c__DisplayClass0_0.NativeMethodInfoPtr__execute_b__1_Internal_Boolean_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x00070858 File Offset: 0x0006EA58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 689034, RefRangeEnd = 689036, XrefRangeStart = 689033, XrefRangeEnd = 689034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Method_Internal_Boolean_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialFTTFlow.__c__DisplayClass0_0.NativeMethodInfoPtr_Method_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x00070894 File Offset: 0x0006EA94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 689037, RefRangeEnd = 689039, XrefRangeStart = 689036, XrefRangeEnd = 689037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Method_Internal_Boolean_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialFTTFlow.__c__DisplayClass0_0.NativeMethodInfoPtr_Method_Internal_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x00010786 File Offset: 0x0000E986
		public __c__DisplayClass0_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x000708D0 File Offset: 0x0006EAD0
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x0001078F File Offset: 0x0000E98F
		public unsafe IAPStoreBehaviour iapStoreBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow.__c__DisplayClass0_0.NativeFieldInfoPtr_iapStoreBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow.__c__DisplayClass0_0.NativeFieldInfoPtr_iapStoreBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x00070900 File Offset: 0x0006EB00
		// (set) Token: 0x06001CCB RID: 7371 RVA: 0x000107AE File Offset: 0x0000E9AE
		public unsafe ProductUtils productUtils
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow.__c__DisplayClass0_0.NativeFieldInfoPtr_productUtils);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductUtils>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow.__c__DisplayClass0_0.NativeFieldInfoPtr_productUtils), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeFieldInfoPtr_iapStoreBehaviour;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeFieldInfoPtr_productUtils;

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_Boolean_2;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__1_Internal_Boolean_2;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_0;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_1;
	}

	// Token: 0x020002C3 RID: 707
	[ObfuscatedName("WormTutorialFTTFlow+<>c__DisplayClass0_1")]
	public sealed class __c__DisplayClass0_1 : Object
	{
		// Token: 0x06001CCC RID: 7372 RVA: 0x00070930 File Offset: 0x0006EB30
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass0_1()
		{
			Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialFTTFlow>.NativeClassPtr, "<>c__DisplayClass0_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_1>.NativeClassPtr);
			WormTutorialFTTFlow.__c__DisplayClass0_1.NativeFieldInfoPtr_menusPrompter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_1>.NativeClassPtr, "menusPrompter");
			WormTutorialFTTFlow.__c__DisplayClass0_1.NativeFieldInfoPtr_field_Public___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_1>.NativeClassPtr, "CS$<>8__locals1");
			WormTutorialFTTFlow.__c__DisplayClass0_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_1>.NativeClassPtr, 100663551);
			WormTutorialFTTFlow.__c__DisplayClass0_1.NativeMethodInfoPtr__execute_b__4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_1>.NativeClassPtr, 100663552);
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x000709AC File Offset: 0x0006EBAC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass0_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_1>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialFTTFlow.__c__DisplayClass0_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x000709E8 File Offset: 0x0006EBE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689039, XrefRangeEnd = 689044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _execute_b__4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialFTTFlow.__c__DisplayClass0_1.NativeMethodInfoPtr__execute_b__4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x000107CD File Offset: 0x0000E9CD
		public __c__DisplayClass0_1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x00070A24 File Offset: 0x0006EC24
		// (set) Token: 0x06001CD1 RID: 7377 RVA: 0x000107D6 File Offset: 0x0000E9D6
		public unsafe IModalPrompter menusPrompter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow.__c__DisplayClass0_1.NativeFieldInfoPtr_menusPrompter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IModalPrompter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow.__c__DisplayClass0_1.NativeFieldInfoPtr_menusPrompter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x00070A54 File Offset: 0x0006EC54
		// (set) Token: 0x06001CD3 RID: 7379 RVA: 0x000107F5 File Offset: 0x0000E9F5
		public unsafe WormTutorialFTTFlow.__c__DisplayClass0_0 field_Public___c__DisplayClass0_0_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow.__c__DisplayClass0_1.NativeFieldInfoPtr_field_Public___c__DisplayClass0_0_0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTutorialFTTFlow.__c__DisplayClass0_0>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow.__c__DisplayClass0_1.NativeFieldInfoPtr_field_Public___c__DisplayClass0_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeFieldInfoPtr_menusPrompter;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass0_0_0;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__4_Internal_Boolean_0;
	}

	// Token: 0x020002C4 RID: 708
	[ObfuscatedName("WormTutorialFTTFlow+<>c__DisplayClass0_2")]
	public sealed class __c__DisplayClass0_2 : Object
	{
		// Token: 0x06001CD4 RID: 7380 RVA: 0x00070A84 File Offset: 0x0006EC84
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass0_2()
		{
			Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialFTTFlow>.NativeClassPtr, "<>c__DisplayClass0_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_2>.NativeClassPtr);
			WormTutorialFTTFlow.__c__DisplayClass0_2.NativeFieldInfoPtr_menusPrompter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_2>.NativeClassPtr, "menusPrompter");
			WormTutorialFTTFlow.__c__DisplayClass0_2.NativeFieldInfoPtr_field_Public___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_2>.NativeClassPtr, "CS$<>8__locals2");
			WormTutorialFTTFlow.__c__DisplayClass0_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_2>.NativeClassPtr, 100663553);
			WormTutorialFTTFlow.__c__DisplayClass0_2.NativeMethodInfoPtr__execute_b__5_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_2>.NativeClassPtr, 100663554);
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x00070B00 File Offset: 0x0006ED00
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass0_2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialFTTFlow.__c__DisplayClass0_2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialFTTFlow.__c__DisplayClass0_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x00070B3C File Offset: 0x0006ED3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689044, XrefRangeEnd = 689049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _execute_b__5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialFTTFlow.__c__DisplayClass0_2.NativeMethodInfoPtr__execute_b__5_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x00010814 File Offset: 0x0000EA14
		public __c__DisplayClass0_2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x00070B78 File Offset: 0x0006ED78
		// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x0001081D File Offset: 0x0000EA1D
		public unsafe IModalPrompter menusPrompter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow.__c__DisplayClass0_2.NativeFieldInfoPtr_menusPrompter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IModalPrompter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow.__c__DisplayClass0_2.NativeFieldInfoPtr_menusPrompter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001CDA RID: 7386 RVA: 0x00070BA8 File Offset: 0x0006EDA8
		// (set) Token: 0x06001CDB RID: 7387 RVA: 0x0001083C File Offset: 0x0000EA3C
		public unsafe WormTutorialFTTFlow.__c__DisplayClass0_0 field_Public___c__DisplayClass0_0_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow.__c__DisplayClass0_2.NativeFieldInfoPtr_field_Public___c__DisplayClass0_0_0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTutorialFTTFlow.__c__DisplayClass0_0>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow.__c__DisplayClass0_2.NativeFieldInfoPtr_field_Public___c__DisplayClass0_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeFieldInfoPtr_menusPrompter;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass0_0_0;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__5_Internal_Boolean_0;
	}

	// Token: 0x020002C5 RID: 709
	[ObfuscatedName("WormTutorialFTTFlow+<execute>d__0")]
	public sealed class _execute_d__0 : Object
	{
		// Token: 0x06001CDC RID: 7388 RVA: 0x00070BD8 File Offset: 0x0006EDD8
		// Note: this type is marked as 'beforefieldinit'.
		static _execute_d__0()
		{
			Il2CppClassPointerStore<WormTutorialFTTFlow._execute_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialFTTFlow>.NativeClassPtr, "<execute>d__0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialFTTFlow._execute_d__0>.NativeClassPtr);
			WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialFTTFlow._execute_d__0>.NativeClassPtr, "<>1__state");
			WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialFTTFlow._execute_d__0>.NativeClassPtr, "<>2__current");
			WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialFTTFlow._execute_d__0>.NativeClassPtr, "<>8__1");
			WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr___8__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialFTTFlow._execute_d__0>.NativeClassPtr, "<>8__2");
			WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr___8__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialFTTFlow._execute_d__0>.NativeClassPtr, "<>8__3");
			WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr__modalScopes_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialFTTFlow._execute_d__0>.NativeClassPtr, "<modalScopes>5__2");
			WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr__prompt_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialFTTFlow._execute_d__0>.NativeClassPtr, "<prompt>5__3");
			WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr__promptData_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialFTTFlow._execute_d__0>.NativeClassPtr, "<promptData>5__4");
			WormTutorialFTTFlow._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialFTTFlow._execute_d__0>.NativeClassPtr, 100663555);
			WormTutorialFTTFlow._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialFTTFlow._execute_d__0>.NativeClassPtr, 100663556);
			WormTutorialFTTFlow._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialFTTFlow._execute_d__0>.NativeClassPtr, 100663557);
			WormTutorialFTTFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialFTTFlow._execute_d__0>.NativeClassPtr, 100663558);
			WormTutorialFTTFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialFTTFlow._execute_d__0>.NativeClassPtr, 100663559);
			WormTutorialFTTFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialFTTFlow._execute_d__0>.NativeClassPtr, 100663560);
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x00070D1C File Offset: 0x0006EF1C
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _execute_d__0(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialFTTFlow._execute_d__0>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialFTTFlow._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x00070D64 File Offset: 0x0006EF64
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialFTTFlow._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x00070D98 File Offset: 0x0006EF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689049, XrefRangeEnd = 689297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialFTTFlow._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x00070DD4 File Offset: 0x0006EFD4
		public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialFTTFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x00070E14 File Offset: 0x0006F014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689297, XrefRangeEnd = 689302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialFTTFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x00070E48 File Offset: 0x0006F048
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialFTTFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x0001085B File Offset: 0x0000EA5B
		public _execute_d__0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x00070E88 File Offset: 0x0006F088
		// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x00010864 File Offset: 0x0000EA64
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x00070EB0 File Offset: 0x0006F0B0
		// (set) Token: 0x06001CE7 RID: 7399 RVA: 0x0001087F File Offset: 0x0000EA7F
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x00070EE0 File Offset: 0x0006F0E0
		// (set) Token: 0x06001CE9 RID: 7401 RVA: 0x0001089E File Offset: 0x0000EA9E
		public unsafe WormTutorialFTTFlow.__c__DisplayClass0_1 __8__1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr___8__1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTutorialFTTFlow.__c__DisplayClass0_1>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001CEA RID: 7402 RVA: 0x00070F10 File Offset: 0x0006F110
		// (set) Token: 0x06001CEB RID: 7403 RVA: 0x000108BD File Offset: 0x0000EABD
		public unsafe WormTutorialFTTFlow.__c__DisplayClass0_2 __8__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr___8__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTutorialFTTFlow.__c__DisplayClass0_2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr___8__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001CEC RID: 7404 RVA: 0x00070F40 File Offset: 0x0006F140
		// (set) Token: 0x06001CED RID: 7405 RVA: 0x000108DC File Offset: 0x0000EADC
		public unsafe WormTutorialFTTFlow.__c__DisplayClass0_0 __8__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr___8__3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTutorialFTTFlow.__c__DisplayClass0_0>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr___8__3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001CEE RID: 7406 RVA: 0x00070F70 File Offset: 0x0006F170
		// (set) Token: 0x06001CEF RID: 7407 RVA: 0x000108FB File Offset: 0x0000EAFB
		public unsafe ModalScopes _modalScopes_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr__modalScopes_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScopes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr__modalScopes_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x00070FA0 File Offset: 0x0006F1A0
		// (set) Token: 0x06001CF1 RID: 7409 RVA: 0x0001091A File Offset: 0x0000EB1A
		public unsafe ConfirmOrDenyPrompt _prompt_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr__prompt_5__3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr__prompt_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x00070FD0 File Offset: 0x0006F1D0
		// (set) Token: 0x06001CF3 RID: 7411 RVA: 0x00010939 File Offset: 0x0000EB39
		public unsafe DataComposition _promptData_5__4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr__promptData_5__4);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialFTTFlow._execute_d__0.NativeFieldInfoPtr__promptData_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeFieldInfoPtr___8__1;

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeFieldInfoPtr___8__2;

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeFieldInfoPtr___8__3;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeFieldInfoPtr__modalScopes_5__2;

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeFieldInfoPtr__prompt_5__3;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeFieldInfoPtr__promptData_5__4;

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
