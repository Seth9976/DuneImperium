using System;
using boardgames.match.behaviours;
using Canis.attributes;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace worm.match.dataRenderers
{
	// Token: 0x0200013A RID: 314
	public class WormHiddenElementRenderer : VersionedView<IAttribute<List<string>>>
	{
		// Token: 0x06000E1C RID: 3612 RVA: 0x00042B20 File Offset: 0x00040D20
		// Note: this type is marked as 'beforefieldinit'.
		static WormHiddenElementRenderer()
		{
			Il2CppClassPointerStore<WormHiddenElementRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormHiddenElementRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHiddenElementRenderer>.NativeClassPtr);
			WormHiddenElementRenderer.NativeFieldInfoPtr_elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHiddenElementRenderer>.NativeClassPtr, "elementName");
			WormHiddenElementRenderer.NativeFieldInfoPtr_onShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHiddenElementRenderer>.NativeClassPtr, "onShown");
			WormHiddenElementRenderer.NativeFieldInfoPtr_hidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHiddenElementRenderer>.NativeClassPtr, "hidden");
			WormHiddenElementRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHiddenElementRenderer>.NativeClassPtr, 100665208);
			WormHiddenElementRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHiddenElementRenderer>.NativeClassPtr, 100665209);
			WormHiddenElementRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHiddenElementRenderer>.NativeClassPtr, 100665210);
			WormHiddenElementRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHiddenElementRenderer>.NativeClassPtr, 100665211);
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00042BDC File Offset: 0x00040DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706240, XrefRangeEnd = 706249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHiddenElementRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00042C18 File Offset: 0x00040E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706249, XrefRangeEnd = 706254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHiddenElementRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00042C58 File Offset: 0x00040E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706254, XrefRangeEnd = 706264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHiddenElementRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00042C94 File Offset: 0x00040E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706264, XrefRangeEnd = 706275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormHiddenElementRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHiddenElementRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHiddenElementRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x000096C6 File Offset: 0x000078C6
		public WormHiddenElementRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x00042CD0 File Offset: 0x00040ED0
		// (set) Token: 0x06000E23 RID: 3619 RVA: 0x000096CF File Offset: 0x000078CF
		public unsafe string elementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHiddenElementRenderer.NativeFieldInfoPtr_elementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHiddenElementRenderer.NativeFieldInfoPtr_elementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x00042CF8 File Offset: 0x00040EF8
		// (set) Token: 0x06000E25 RID: 3621 RVA: 0x000096EE File Offset: 0x000078EE
		public unsafe BoolUnityEvents onShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHiddenElementRenderer.NativeFieldInfoPtr_onShown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHiddenElementRenderer.NativeFieldInfoPtr_onShown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000E26 RID: 3622 RVA: 0x00042D28 File Offset: 0x00040F28
		// (set) Token: 0x06000E27 RID: 3623 RVA: 0x0000970D File Offset: 0x0000790D
		public unsafe bool hidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHiddenElementRenderer.NativeFieldInfoPtr_hidden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHiddenElementRenderer.NativeFieldInfoPtr_hidden)) = value;
			}
		}

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeFieldInfoPtr_elementName;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeFieldInfoPtr_onShown;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeFieldInfoPtr_hidden;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200038D RID: 909
		[ObfuscatedName("worm.match.dataRenderers.WormHiddenElementRenderer+<Init>d__4")]
		public sealed class _Init_d__4 : Object
		{
			// Token: 0x06002481 RID: 9345 RVA: 0x00086810 File Offset: 0x00084A10
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__4()
			{
				Il2CppClassPointerStore<WormHiddenElementRenderer._Init_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormHiddenElementRenderer>.NativeClassPtr, "<Init>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHiddenElementRenderer._Init_d__4>.NativeClassPtr);
				WormHiddenElementRenderer._Init_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHiddenElementRenderer._Init_d__4>.NativeClassPtr, "<>1__state");
				WormHiddenElementRenderer._Init_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHiddenElementRenderer._Init_d__4>.NativeClassPtr, "<>2__current");
				WormHiddenElementRenderer._Init_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHiddenElementRenderer._Init_d__4>.NativeClassPtr, "<>4__this");
				WormHiddenElementRenderer._Init_d__4.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHiddenElementRenderer._Init_d__4>.NativeClassPtr, "<entitiesProvider>5__2");
				WormHiddenElementRenderer._Init_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHiddenElementRenderer._Init_d__4>.NativeClassPtr, 100665212);
				WormHiddenElementRenderer._Init_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHiddenElementRenderer._Init_d__4>.NativeClassPtr, 100665213);
				WormHiddenElementRenderer._Init_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHiddenElementRenderer._Init_d__4>.NativeClassPtr, 100665214);
				WormHiddenElementRenderer._Init_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHiddenElementRenderer._Init_d__4>.NativeClassPtr, 100665215);
				WormHiddenElementRenderer._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHiddenElementRenderer._Init_d__4>.NativeClassPtr, 100665216);
				WormHiddenElementRenderer._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHiddenElementRenderer._Init_d__4>.NativeClassPtr, 100665217);
			}

			// Token: 0x06002482 RID: 9346 RVA: 0x00086904 File Offset: 0x00084B04
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHiddenElementRenderer._Init_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHiddenElementRenderer._Init_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002483 RID: 9347 RVA: 0x0008694C File Offset: 0x00084B4C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHiddenElementRenderer._Init_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002484 RID: 9348 RVA: 0x00086980 File Offset: 0x00084B80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706227, XrefRangeEnd = 706235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHiddenElementRenderer._Init_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A20 RID: 2592
			// (get) Token: 0x06002485 RID: 9349 RVA: 0x000869BC File Offset: 0x00084BBC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHiddenElementRenderer._Init_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002486 RID: 9350 RVA: 0x000869FC File Offset: 0x00084BFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706235, XrefRangeEnd = 706240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHiddenElementRenderer._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A21 RID: 2593
			// (get) Token: 0x06002487 RID: 9351 RVA: 0x00086A30 File Offset: 0x00084C30
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHiddenElementRenderer._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002488 RID: 9352 RVA: 0x000145EA File Offset: 0x000127EA
			public _Init_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A1C RID: 2588
			// (get) Token: 0x06002489 RID: 9353 RVA: 0x00086A70 File Offset: 0x00084C70
			// (set) Token: 0x0600248A RID: 9354 RVA: 0x000145F3 File Offset: 0x000127F3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHiddenElementRenderer._Init_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHiddenElementRenderer._Init_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A1D RID: 2589
			// (get) Token: 0x0600248B RID: 9355 RVA: 0x00086A98 File Offset: 0x00084C98
			// (set) Token: 0x0600248C RID: 9356 RVA: 0x0001460E File Offset: 0x0001280E
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHiddenElementRenderer._Init_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHiddenElementRenderer._Init_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A1E RID: 2590
			// (get) Token: 0x0600248D RID: 9357 RVA: 0x00086AC8 File Offset: 0x00084CC8
			// (set) Token: 0x0600248E RID: 9358 RVA: 0x0001462D File Offset: 0x0001282D
			public unsafe WormHiddenElementRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHiddenElementRenderer._Init_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormHiddenElementRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHiddenElementRenderer._Init_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A1F RID: 2591
			// (get) Token: 0x0600248F RID: 9359 RVA: 0x00086AF8 File Offset: 0x00084CF8
			// (set) Token: 0x06002490 RID: 9360 RVA: 0x0001464C File Offset: 0x0001284C
			public unsafe DBGEntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHiddenElementRenderer._Init_d__4.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHiddenElementRenderer._Init_d__4.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014F1 RID: 5361
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014F2 RID: 5362
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040014F3 RID: 5363
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014F4 RID: 5364
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x040014F5 RID: 5365
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040014F6 RID: 5366
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014F7 RID: 5367
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040014F8 RID: 5368
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040014F9 RID: 5369
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014FA RID: 5370
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
