using System;
using boardgames.src.broadcast.motd;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace dwd.core.direBytes
{
	// Token: 0x02000007 RID: 7
	public class DireByteAlertImageRenderer : VersionedSubscriber<DireBytesPrefabData>
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00003B2C File Offset: 0x00001D2C
		// Note: this type is marked as 'beforefieldinit'.
		static DireByteAlertImageRenderer()
		{
			Il2CppClassPointerStore<DireByteAlertImageRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes", "DireByteAlertImageRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireByteAlertImageRenderer>.NativeClassPtr);
			DireByteAlertImageRenderer.NativeFieldInfoPtr_FallbackAddressableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteAlertImageRenderer>.NativeClassPtr, "FallbackAddressableName");
			DireByteAlertImageRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteAlertImageRenderer>.NativeClassPtr, "image");
			DireByteAlertImageRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteAlertImageRenderer>.NativeClassPtr, 100663305);
			DireByteAlertImageRenderer.NativeMethodInfoPtr_updateImage_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteAlertImageRenderer>.NativeClassPtr, 100663306);
			DireByteAlertImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteAlertImageRenderer>.NativeClassPtr, 100663307);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003BC0 File Offset: 0x00001DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233376, XrefRangeEnd = 1233382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DireByteAlertImageRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003BFC File Offset: 0x00001DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233382, XrefRangeEnd = 1233387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator updateImage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteAlertImageRenderer.NativeMethodInfoPtr_updateImage_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003C3C File Offset: 0x00001E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233387, XrefRangeEnd = 1233390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireByteAlertImageRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireByteAlertImageRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteAlertImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000020F0 File Offset: 0x000002F0
		public DireByteAlertImageRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00003C78 File Offset: 0x00001E78
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000020F9 File Offset: 0x000002F9
		public unsafe static string FallbackAddressableName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DireByteAlertImageRenderer.NativeFieldInfoPtr_FallbackAddressableName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DireByteAlertImageRenderer.NativeFieldInfoPtr_FallbackAddressableName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00003C98 File Offset: 0x00001E98
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0000210B File Offset: 0x0000030B
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteAlertImageRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteAlertImageRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_FallbackAddressableName;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_updateImage_Private_IEnumerator_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200002A RID: 42
		[ObfuscatedName("dwd.core.direBytes.DireByteAlertImageRenderer+<updateImage>d__3")]
		public sealed class _updateImage_d__3 : global::Il2CppSystem.Object
		{
			// Token: 0x060001D7 RID: 471 RVA: 0x00008920 File Offset: 0x00006B20
			// Note: this type is marked as 'beforefieldinit'.
			static _updateImage_d__3()
			{
				Il2CppClassPointerStore<DireByteAlertImageRenderer._updateImage_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DireByteAlertImageRenderer>.NativeClassPtr, "<updateImage>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireByteAlertImageRenderer._updateImage_d__3>.NativeClassPtr);
				DireByteAlertImageRenderer._updateImage_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteAlertImageRenderer._updateImage_d__3>.NativeClassPtr, "<>1__state");
				DireByteAlertImageRenderer._updateImage_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteAlertImageRenderer._updateImage_d__3>.NativeClassPtr, "<>2__current");
				DireByteAlertImageRenderer._updateImage_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteAlertImageRenderer._updateImage_d__3>.NativeClassPtr, "<>4__this");
				DireByteAlertImageRenderer._updateImage_d__3.NativeFieldInfoPtr__newSprite_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteAlertImageRenderer._updateImage_d__3>.NativeClassPtr, "<newSprite>5__2");
				DireByteAlertImageRenderer._updateImage_d__3.NativeFieldInfoPtr__imageName_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteAlertImageRenderer._updateImage_d__3>.NativeClassPtr, "<imageName>5__3");
				DireByteAlertImageRenderer._updateImage_d__3.NativeFieldInfoPtr__broadcast_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteAlertImageRenderer._updateImage_d__3>.NativeClassPtr, "<broadcast>5__4");
				DireByteAlertImageRenderer._updateImage_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteAlertImageRenderer._updateImage_d__3>.NativeClassPtr, 100663308);
				DireByteAlertImageRenderer._updateImage_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteAlertImageRenderer._updateImage_d__3>.NativeClassPtr, 100663309);
				DireByteAlertImageRenderer._updateImage_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteAlertImageRenderer._updateImage_d__3>.NativeClassPtr, 100663310);
				DireByteAlertImageRenderer._updateImage_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteAlertImageRenderer._updateImage_d__3>.NativeClassPtr, 100663311);
				DireByteAlertImageRenderer._updateImage_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteAlertImageRenderer._updateImage_d__3>.NativeClassPtr, 100663312);
				DireByteAlertImageRenderer._updateImage_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteAlertImageRenderer._updateImage_d__3>.NativeClassPtr, 100663313);
			}

			// Token: 0x060001D8 RID: 472 RVA: 0x00008A3C File Offset: 0x00006C3C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _updateImage_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireByteAlertImageRenderer._updateImage_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteAlertImageRenderer._updateImage_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001D9 RID: 473 RVA: 0x00008A84 File Offset: 0x00006C84
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteAlertImageRenderer._updateImage_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001DA RID: 474 RVA: 0x00008AB8 File Offset: 0x00006CB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233349, XrefRangeEnd = 1233371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteAlertImageRenderer._updateImage_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x060001DB RID: 475 RVA: 0x00008AF4 File Offset: 0x00006CF4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteAlertImageRenderer._updateImage_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060001DC RID: 476 RVA: 0x00008B34 File Offset: 0x00006D34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233371, XrefRangeEnd = 1233376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteAlertImageRenderer._updateImage_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x060001DD RID: 477 RVA: 0x00008B68 File Offset: 0x00006D68
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteAlertImageRenderer._updateImage_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060001DE RID: 478 RVA: 0x0000305C File Offset: 0x0000125C
			public _updateImage_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x060001DF RID: 479 RVA: 0x00008BA8 File Offset: 0x00006DA8
			// (set) Token: 0x060001E0 RID: 480 RVA: 0x00003065 File Offset: 0x00001265
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteAlertImageRenderer._updateImage_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteAlertImageRenderer._updateImage_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x060001E1 RID: 481 RVA: 0x00008BD0 File Offset: 0x00006DD0
			// (set) Token: 0x060001E2 RID: 482 RVA: 0x00003080 File Offset: 0x00001280
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteAlertImageRenderer._updateImage_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteAlertImageRenderer._updateImage_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x060001E3 RID: 483 RVA: 0x00008C00 File Offset: 0x00006E00
			// (set) Token: 0x060001E4 RID: 484 RVA: 0x0000309F File Offset: 0x0000129F
			public unsafe DireByteAlertImageRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteAlertImageRenderer._updateImage_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DireByteAlertImageRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteAlertImageRenderer._updateImage_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x060001E5 RID: 485 RVA: 0x00008C30 File Offset: 0x00006E30
			// (set) Token: 0x060001E6 RID: 486 RVA: 0x000030BE File Offset: 0x000012BE
			public unsafe Sprite _newSprite_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteAlertImageRenderer._updateImage_d__3.NativeFieldInfoPtr__newSprite_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteAlertImageRenderer._updateImage_d__3.NativeFieldInfoPtr__newSprite_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x060001E7 RID: 487 RVA: 0x00008C60 File Offset: 0x00006E60
			// (set) Token: 0x060001E8 RID: 488 RVA: 0x000030DD File Offset: 0x000012DD
			public unsafe string _imageName_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteAlertImageRenderer._updateImage_d__3.NativeFieldInfoPtr__imageName_5__3);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteAlertImageRenderer._updateImage_d__3.NativeFieldInfoPtr__imageName_5__3), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x060001E9 RID: 489 RVA: 0x00008C88 File Offset: 0x00006E88
			// (set) Token: 0x060001EA RID: 490 RVA: 0x000030FC File Offset: 0x000012FC
			public unsafe BroadcastContentProvider _broadcast_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteAlertImageRenderer._updateImage_d__3.NativeFieldInfoPtr__broadcast_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BroadcastContentProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteAlertImageRenderer._updateImage_d__3.NativeFieldInfoPtr__broadcast_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000105 RID: 261
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000106 RID: 262
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000107 RID: 263
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000108 RID: 264
			private static readonly IntPtr NativeFieldInfoPtr__newSprite_5__2;

			// Token: 0x04000109 RID: 265
			private static readonly IntPtr NativeFieldInfoPtr__imageName_5__3;

			// Token: 0x0400010A RID: 266
			private static readonly IntPtr NativeFieldInfoPtr__broadcast_5__4;

			// Token: 0x0400010B RID: 267
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400010C RID: 268
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400010D RID: 269
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400010E RID: 270
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400010F RID: 271
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000110 RID: 272
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
