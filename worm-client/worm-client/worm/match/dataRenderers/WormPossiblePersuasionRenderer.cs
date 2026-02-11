using System;
using boardgames.match.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000153 RID: 339
	public class WormPossiblePersuasionRenderer : VersionedView<WormPersuasionData>
	{
		// Token: 0x06000F22 RID: 3874 RVA: 0x000459A8 File Offset: 0x00043BA8
		// Note: this type is marked as 'beforefieldinit'.
		static WormPossiblePersuasionRenderer()
		{
			Il2CppClassPointerStore<WormPossiblePersuasionRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormPossiblePersuasionRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPossiblePersuasionRenderer>.NativeClassPtr);
			WormPossiblePersuasionRenderer.NativeFieldInfoPtr_labelComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPossiblePersuasionRenderer>.NativeClassPtr, "labelComponent");
			WormPossiblePersuasionRenderer.NativeFieldInfoPtr_textComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPossiblePersuasionRenderer>.NativeClassPtr, "textComponent");
			WormPossiblePersuasionRenderer.NativeFieldInfoPtr_optionalTextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPossiblePersuasionRenderer>.NativeClassPtr, "optionalTextComponent");
			WormPossiblePersuasionRenderer.NativeFieldInfoPtr_specimenTextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPossiblePersuasionRenderer>.NativeClassPtr, "specimenTextComponent");
			WormPossiblePersuasionRenderer.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPossiblePersuasionRenderer>.NativeClassPtr, "label");
			WormPossiblePersuasionRenderer.NativeFieldInfoPtr_optionalTextDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPossiblePersuasionRenderer>.NativeClassPtr, "optionalTextDisplays");
			WormPossiblePersuasionRenderer.NativeFieldInfoPtr_preRevealPersuasion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPossiblePersuasionRenderer>.NativeClassPtr, "preRevealPersuasion");
			WormPossiblePersuasionRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPossiblePersuasionRenderer>.NativeClassPtr, 100665340);
			WormPossiblePersuasionRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPossiblePersuasionRenderer>.NativeClassPtr, 100665341);
			WormPossiblePersuasionRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPossiblePersuasionRenderer>.NativeClassPtr, 100665342);
			WormPossiblePersuasionRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPossiblePersuasionRenderer>.NativeClassPtr, 100665343);
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x00045AB4 File Offset: 0x00043CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707444, XrefRangeEnd = 707453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPossiblePersuasionRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00045AF0 File Offset: 0x00043CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707453, XrefRangeEnd = 707458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPossiblePersuasionRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x00045B30 File Offset: 0x00043D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707458, XrefRangeEnd = 707518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPossiblePersuasionRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x00045B6C File Offset: 0x00043D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707518, XrefRangeEnd = 707525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPossiblePersuasionRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPossiblePersuasionRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPossiblePersuasionRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x00009F5F File Offset: 0x0000815F
		public WormPossiblePersuasionRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x00045BA8 File Offset: 0x00043DA8
		// (set) Token: 0x06000F29 RID: 3881 RVA: 0x00009F68 File Offset: 0x00008168
		public unsafe TMP_Text labelComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer.NativeFieldInfoPtr_labelComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer.NativeFieldInfoPtr_labelComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x00045BD8 File Offset: 0x00043DD8
		// (set) Token: 0x06000F2B RID: 3883 RVA: 0x00009F87 File Offset: 0x00008187
		public unsafe TMP_Text textComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer.NativeFieldInfoPtr_textComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer.NativeFieldInfoPtr_textComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x00045C08 File Offset: 0x00043E08
		// (set) Token: 0x06000F2D RID: 3885 RVA: 0x00009FA6 File Offset: 0x000081A6
		public unsafe TMP_Text optionalTextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer.NativeFieldInfoPtr_optionalTextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer.NativeFieldInfoPtr_optionalTextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x00045C38 File Offset: 0x00043E38
		// (set) Token: 0x06000F2F RID: 3887 RVA: 0x00009FC5 File Offset: 0x000081C5
		public unsafe TMP_Text specimenTextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer.NativeFieldInfoPtr_specimenTextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer.NativeFieldInfoPtr_specimenTextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x00045C68 File Offset: 0x00043E68
		// (set) Token: 0x06000F31 RID: 3889 RVA: 0x00009FE4 File Offset: 0x000081E4
		public unsafe GameObject label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer.NativeFieldInfoPtr_label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer.NativeFieldInfoPtr_label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x00045C98 File Offset: 0x00043E98
		// (set) Token: 0x06000F33 RID: 3891 RVA: 0x0000A003 File Offset: 0x00008203
		public unsafe Il2CppReferenceArray<GameObject> optionalTextDisplays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer.NativeFieldInfoPtr_optionalTextDisplays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer.NativeFieldInfoPtr_optionalTextDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x00045CC8 File Offset: 0x00043EC8
		// (set) Token: 0x06000F35 RID: 3893 RVA: 0x0000A022 File Offset: 0x00008222
		public unsafe int preRevealPersuasion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer.NativeFieldInfoPtr_preRevealPersuasion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer.NativeFieldInfoPtr_preRevealPersuasion)) = value;
			}
		}

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeFieldInfoPtr_labelComponent;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeFieldInfoPtr_textComponent;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeFieldInfoPtr_optionalTextComponent;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeFieldInfoPtr_specimenTextComponent;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeFieldInfoPtr_optionalTextDisplays;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeFieldInfoPtr_preRevealPersuasion;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200039B RID: 923
		[ObfuscatedName("worm.match.dataRenderers.WormPossiblePersuasionRenderer+<Init>d__8")]
		public sealed class _Init_d__8 : global::Il2CppSystem.Object
		{
			// Token: 0x0600251D RID: 9501 RVA: 0x000883E0 File Offset: 0x000865E0
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__8()
			{
				Il2CppClassPointerStore<WormPossiblePersuasionRenderer._Init_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPossiblePersuasionRenderer>.NativeClassPtr, "<Init>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPossiblePersuasionRenderer._Init_d__8>.NativeClassPtr);
				WormPossiblePersuasionRenderer._Init_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPossiblePersuasionRenderer._Init_d__8>.NativeClassPtr, "<>1__state");
				WormPossiblePersuasionRenderer._Init_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPossiblePersuasionRenderer._Init_d__8>.NativeClassPtr, "<>2__current");
				WormPossiblePersuasionRenderer._Init_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPossiblePersuasionRenderer._Init_d__8>.NativeClassPtr, "<>4__this");
				WormPossiblePersuasionRenderer._Init_d__8.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPossiblePersuasionRenderer._Init_d__8>.NativeClassPtr, "<entitiesProvider>5__2");
				WormPossiblePersuasionRenderer._Init_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPossiblePersuasionRenderer._Init_d__8>.NativeClassPtr, 100665344);
				WormPossiblePersuasionRenderer._Init_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPossiblePersuasionRenderer._Init_d__8>.NativeClassPtr, 100665345);
				WormPossiblePersuasionRenderer._Init_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPossiblePersuasionRenderer._Init_d__8>.NativeClassPtr, 100665346);
				WormPossiblePersuasionRenderer._Init_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPossiblePersuasionRenderer._Init_d__8>.NativeClassPtr, 100665347);
				WormPossiblePersuasionRenderer._Init_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPossiblePersuasionRenderer._Init_d__8>.NativeClassPtr, 100665348);
				WormPossiblePersuasionRenderer._Init_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPossiblePersuasionRenderer._Init_d__8>.NativeClassPtr, 100665349);
			}

			// Token: 0x0600251E RID: 9502 RVA: 0x000884D4 File Offset: 0x000866D4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPossiblePersuasionRenderer._Init_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPossiblePersuasionRenderer._Init_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600251F RID: 9503 RVA: 0x0008851C File Offset: 0x0008671C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPossiblePersuasionRenderer._Init_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002520 RID: 9504 RVA: 0x00088550 File Offset: 0x00086750
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707403, XrefRangeEnd = 707439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPossiblePersuasionRenderer._Init_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A55 RID: 2645
			// (get) Token: 0x06002521 RID: 9505 RVA: 0x0008858C File Offset: 0x0008678C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPossiblePersuasionRenderer._Init_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002522 RID: 9506 RVA: 0x000885CC File Offset: 0x000867CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707439, XrefRangeEnd = 707444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPossiblePersuasionRenderer._Init_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A56 RID: 2646
			// (get) Token: 0x06002523 RID: 9507 RVA: 0x00088600 File Offset: 0x00086800
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPossiblePersuasionRenderer._Init_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002524 RID: 9508 RVA: 0x00014AE0 File Offset: 0x00012CE0
			public _Init_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A51 RID: 2641
			// (get) Token: 0x06002525 RID: 9509 RVA: 0x00088640 File Offset: 0x00086840
			// (set) Token: 0x06002526 RID: 9510 RVA: 0x00014AE9 File Offset: 0x00012CE9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer._Init_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer._Init_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A52 RID: 2642
			// (get) Token: 0x06002527 RID: 9511 RVA: 0x00088668 File Offset: 0x00086868
			// (set) Token: 0x06002528 RID: 9512 RVA: 0x00014B04 File Offset: 0x00012D04
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer._Init_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer._Init_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A53 RID: 2643
			// (get) Token: 0x06002529 RID: 9513 RVA: 0x00088698 File Offset: 0x00086898
			// (set) Token: 0x0600252A RID: 9514 RVA: 0x00014B23 File Offset: 0x00012D23
			public unsafe WormPossiblePersuasionRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer._Init_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPossiblePersuasionRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer._Init_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A54 RID: 2644
			// (get) Token: 0x0600252B RID: 9515 RVA: 0x000886C8 File Offset: 0x000868C8
			// (set) Token: 0x0600252C RID: 9516 RVA: 0x00014B42 File Offset: 0x00012D42
			public unsafe DBGEntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer._Init_d__8.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPossiblePersuasionRenderer._Init_d__8.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400154C RID: 5452
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400154D RID: 5453
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400154E RID: 5454
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400154F RID: 5455
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x04001550 RID: 5456
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001551 RID: 5457
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001552 RID: 5458
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001553 RID: 5459
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001554 RID: 5460
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001555 RID: 5461
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
