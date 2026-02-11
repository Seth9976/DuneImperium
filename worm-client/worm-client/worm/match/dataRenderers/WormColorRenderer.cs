using System;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000108 RID: 264
	public class WormColorRenderer : VersionedView<WormColorData>
	{
		// Token: 0x06000BCB RID: 3019 RVA: 0x0003BCC8 File Offset: 0x00039EC8
		// Note: this type is marked as 'beforefieldinit'.
		static WormColorRenderer()
		{
			Il2CppClassPointerStore<WormColorRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormColorRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormColorRenderer>.NativeClassPtr);
			WormColorRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorRenderer>.NativeClassPtr, 100664915);
			WormColorRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorRenderer>.NativeClassPtr, 100664916);
			WormColorRenderer.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorRenderer>.NativeClassPtr, 100664917);
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x0003BD34 File Offset: 0x00039F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703672, XrefRangeEnd = 703681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormColorRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0003BD70 File Offset: 0x00039F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703681, XrefRangeEnd = 703686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormColorRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0003BDB0 File Offset: 0x00039FB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 703689, RefRangeEnd = 703690, XrefRangeStart = 703686, XrefRangeEnd = 703689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormColorRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormColorRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormColorRenderer.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00008391 File Offset: 0x00006591
		public WormColorRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0200036A RID: 874
		[ObfuscatedName("worm.match.dataRenderers.WormColorRenderer+<Init>d__1")]
		public sealed class _Init_d__1 : Object
		{
			// Token: 0x06002335 RID: 9013 RVA: 0x00082F94 File Offset: 0x00081194
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__1()
			{
				Il2CppClassPointerStore<WormColorRenderer._Init_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormColorRenderer>.NativeClassPtr, "<Init>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormColorRenderer._Init_d__1>.NativeClassPtr);
				WormColorRenderer._Init_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormColorRenderer._Init_d__1>.NativeClassPtr, "<>1__state");
				WormColorRenderer._Init_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormColorRenderer._Init_d__1>.NativeClassPtr, "<>2__current");
				WormColorRenderer._Init_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormColorRenderer._Init_d__1>.NativeClassPtr, "<>4__this");
				WormColorRenderer._Init_d__1.NativeFieldInfoPtr__parent_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormColorRenderer._Init_d__1>.NativeClassPtr, "<parent>5__2");
				WormColorRenderer._Init_d__1.NativeFieldInfoPtr__entitiesProvider_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormColorRenderer._Init_d__1>.NativeClassPtr, "<entitiesProvider>5__3");
				WormColorRenderer._Init_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorRenderer._Init_d__1>.NativeClassPtr, 100664918);
				WormColorRenderer._Init_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorRenderer._Init_d__1>.NativeClassPtr, 100664919);
				WormColorRenderer._Init_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorRenderer._Init_d__1>.NativeClassPtr, 100664920);
				WormColorRenderer._Init_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorRenderer._Init_d__1>.NativeClassPtr, 100664921);
				WormColorRenderer._Init_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorRenderer._Init_d__1>.NativeClassPtr, 100664922);
				WormColorRenderer._Init_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorRenderer._Init_d__1>.NativeClassPtr, 100664923);
			}

			// Token: 0x06002336 RID: 9014 RVA: 0x0008309C File Offset: 0x0008129C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormColorRenderer._Init_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormColorRenderer._Init_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002337 RID: 9015 RVA: 0x000830E4 File Offset: 0x000812E4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormColorRenderer._Init_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002338 RID: 9016 RVA: 0x00083118 File Offset: 0x00081318
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703650, XrefRangeEnd = 703667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormColorRenderer._Init_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170009BA RID: 2490
			// (get) Token: 0x06002339 RID: 9017 RVA: 0x00083154 File Offset: 0x00081354
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormColorRenderer._Init_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600233A RID: 9018 RVA: 0x00083194 File Offset: 0x00081394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703667, XrefRangeEnd = 703672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormColorRenderer._Init_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009BB RID: 2491
			// (get) Token: 0x0600233B RID: 9019 RVA: 0x000831C8 File Offset: 0x000813C8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormColorRenderer._Init_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600233C RID: 9020 RVA: 0x00013AB4 File Offset: 0x00011CB4
			public _Init_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009B5 RID: 2485
			// (get) Token: 0x0600233D RID: 9021 RVA: 0x00083208 File Offset: 0x00081408
			// (set) Token: 0x0600233E RID: 9022 RVA: 0x00013ABD File Offset: 0x00011CBD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorRenderer._Init_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorRenderer._Init_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009B6 RID: 2486
			// (get) Token: 0x0600233F RID: 9023 RVA: 0x00083230 File Offset: 0x00081430
			// (set) Token: 0x06002340 RID: 9024 RVA: 0x00013AD8 File Offset: 0x00011CD8
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorRenderer._Init_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorRenderer._Init_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B7 RID: 2487
			// (get) Token: 0x06002341 RID: 9025 RVA: 0x00083260 File Offset: 0x00081460
			// (set) Token: 0x06002342 RID: 9026 RVA: 0x00013AF7 File Offset: 0x00011CF7
			public unsafe WormColorRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorRenderer._Init_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormColorRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorRenderer._Init_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B8 RID: 2488
			// (get) Token: 0x06002343 RID: 9027 RVA: 0x00083290 File Offset: 0x00081490
			// (set) Token: 0x06002344 RID: 9028 RVA: 0x00013B16 File Offset: 0x00011D16
			public unsafe EntityView _parent_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorRenderer._Init_d__1.NativeFieldInfoPtr__parent_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorRenderer._Init_d__1.NativeFieldInfoPtr__parent_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B9 RID: 2489
			// (get) Token: 0x06002345 RID: 9029 RVA: 0x000832C0 File Offset: 0x000814C0
			// (set) Token: 0x06002346 RID: 9030 RVA: 0x00013B35 File Offset: 0x00011D35
			public unsafe EntitiesProvider _entitiesProvider_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorRenderer._Init_d__1.NativeFieldInfoPtr__entitiesProvider_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorRenderer._Init_d__1.NativeFieldInfoPtr__entitiesProvider_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400143A RID: 5178
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400143B RID: 5179
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400143C RID: 5180
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400143D RID: 5181
			private static readonly IntPtr NativeFieldInfoPtr__parent_5__2;

			// Token: 0x0400143E RID: 5182
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__3;

			// Token: 0x0400143F RID: 5183
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001440 RID: 5184
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001441 RID: 5185
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001442 RID: 5186
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001443 RID: 5187
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001444 RID: 5188
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
