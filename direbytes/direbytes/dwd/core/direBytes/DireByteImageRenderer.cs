using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace dwd.core.direBytes
{
	// Token: 0x02000008 RID: 8
	public class DireByteImageRenderer : VersionedSubscriber<TextBundleImageData>
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00003CC8 File Offset: 0x00001EC8
		// Note: this type is marked as 'beforefieldinit'.
		static DireByteImageRenderer()
		{
			Il2CppClassPointerStore<DireByteImageRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes", "DireByteImageRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireByteImageRenderer>.NativeClassPtr);
			DireByteImageRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteImageRenderer>.NativeClassPtr, "image");
			DireByteImageRenderer.NativeFieldInfoPtr_primaryImageFilePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteImageRenderer>.NativeClassPtr, "primaryImageFilePattern");
			DireByteImageRenderer.NativeFieldInfoPtr_alternateImageFilePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteImageRenderer>.NativeClassPtr, "alternateImageFilePattern");
			DireByteImageRenderer.NativeFieldInfoPtr_spriteName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteImageRenderer>.NativeClassPtr, "spriteName");
			DireByteImageRenderer.NativeFieldInfoPtr_currentDownloadedImageNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteImageRenderer>.NativeClassPtr, "currentDownloadedImageNames");
			DireByteImageRenderer.NativeFieldInfoPtr_spriteNameFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteImageRenderer>.NativeClassPtr, "spriteNameFormat");
			DireByteImageRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteImageRenderer>.NativeClassPtr, 100663314);
			DireByteImageRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteImageRenderer>.NativeClassPtr, 100663315);
			DireByteImageRenderer.NativeMethodInfoPtr_updateImage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteImageRenderer>.NativeClassPtr, 100663316);
			DireByteImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteImageRenderer>.NativeClassPtr, 100663317);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003DC0 File Offset: 0x00001FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233483, XrefRangeEnd = 1233503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DireByteImageRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003DFC File Offset: 0x00001FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233503, XrefRangeEnd = 1233509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DireByteImageRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003E38 File Offset: 0x00002038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateImage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteImageRenderer.NativeMethodInfoPtr_updateImage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003E6C File Offset: 0x0000206C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233509, XrefRangeEnd = 1233524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireByteImageRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireByteImageRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000212A File Offset: 0x0000032A
		public DireByteImageRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00003EA8 File Offset: 0x000020A8
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002133 File Offset: 0x00000333
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteImageRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteImageRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00003ED8 File Offset: 0x000020D8
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002152 File Offset: 0x00000352
		public unsafe string primaryImageFilePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteImageRenderer.NativeFieldInfoPtr_primaryImageFilePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteImageRenderer.NativeFieldInfoPtr_primaryImageFilePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003F00 File Offset: 0x00002100
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002171 File Offset: 0x00000371
		public unsafe string alternateImageFilePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteImageRenderer.NativeFieldInfoPtr_alternateImageFilePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteImageRenderer.NativeFieldInfoPtr_alternateImageFilePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00003F28 File Offset: 0x00002128
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002190 File Offset: 0x00000390
		public unsafe string spriteName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteImageRenderer.NativeFieldInfoPtr_spriteName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteImageRenderer.NativeFieldInfoPtr_spriteName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00003F50 File Offset: 0x00002150
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000021AF File Offset: 0x000003AF
		public unsafe List<string> currentDownloadedImageNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteImageRenderer.NativeFieldInfoPtr_currentDownloadedImageNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteImageRenderer.NativeFieldInfoPtr_currentDownloadedImageNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00003F80 File Offset: 0x00002180
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000021CE File Offset: 0x000003CE
		public unsafe static string spriteNameFormat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DireByteImageRenderer.NativeFieldInfoPtr_spriteNameFormat, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DireByteImageRenderer.NativeFieldInfoPtr_spriteNameFormat, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_primaryImageFilePattern;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_alternateImageFilePattern;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_spriteName;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_currentDownloadedImageNames;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_spriteNameFormat;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_updateImage_Private_Void_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200002B RID: 43
		[ObfuscatedName("dwd.core.direBytes.DireByteImageRenderer+<updateImage>d__8")]
		public sealed class _updateImage_d__8 : ValueType
		{
			// Token: 0x060001EB RID: 491 RVA: 0x00008CB8 File Offset: 0x00006EB8
			// Note: this type is marked as 'beforefieldinit'.
			static _updateImage_d__8()
			{
				Il2CppClassPointerStore<DireByteImageRenderer._updateImage_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DireByteImageRenderer>.NativeClassPtr, "<updateImage>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireByteImageRenderer._updateImage_d__8>.NativeClassPtr);
				DireByteImageRenderer._updateImage_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteImageRenderer._updateImage_d__8>.NativeClassPtr, "<>1__state");
				DireByteImageRenderer._updateImage_d__8.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteImageRenderer._updateImage_d__8>.NativeClassPtr, "<>t__builder");
				DireByteImageRenderer._updateImage_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteImageRenderer._updateImage_d__8>.NativeClassPtr, "<>4__this");
				DireByteImageRenderer._updateImage_d__8.NativeFieldInfoPtr__alternateName_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteImageRenderer._updateImage_d__8>.NativeClassPtr, "<alternateName>5__2");
				DireByteImageRenderer._updateImage_d__8.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteImageRenderer._updateImage_d__8>.NativeClassPtr, "<>u__1");
				DireByteImageRenderer._updateImage_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteImageRenderer._updateImage_d__8>.NativeClassPtr, 100663318);
				DireByteImageRenderer._updateImage_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteImageRenderer._updateImage_d__8>.NativeClassPtr, 100663319);
			}

			// Token: 0x060001EC RID: 492 RVA: 0x00008D70 File Offset: 0x00006F70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233390, XrefRangeEnd = 1233483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteImageRenderer._updateImage_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001ED RID: 493 RVA: 0x00008DA8 File Offset: 0x00006FA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteImageRenderer._updateImage_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001EE RID: 494 RVA: 0x0000311B File Offset: 0x0000131B
			public _updateImage_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060001EF RID: 495 RVA: 0x00003124 File Offset: 0x00001324
			public _updateImage_d__8()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireByteImageRenderer._updateImage_d__8>.NativeClassPtr))
			{
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x060001F0 RID: 496 RVA: 0x00008DF0 File Offset: 0x00006FF0
			// (set) Token: 0x060001F1 RID: 497 RVA: 0x00003136 File Offset: 0x00001336
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteImageRenderer._updateImage_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteImageRenderer._updateImage_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x060001F2 RID: 498 RVA: 0x00008E18 File Offset: 0x00007018
			// (set) Token: 0x060001F3 RID: 499 RVA: 0x00003151 File Offset: 0x00001351
			public AsyncVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteImageRenderer._updateImage_d__8.NativeFieldInfoPtr___t__builder);
					return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteImageRenderer._updateImage_d__8.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x060001F4 RID: 500 RVA: 0x00008E48 File Offset: 0x00007048
			// (set) Token: 0x060001F5 RID: 501 RVA: 0x0000317F File Offset: 0x0000137F
			public unsafe DireByteImageRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteImageRenderer._updateImage_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DireByteImageRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteImageRenderer._updateImage_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x060001F6 RID: 502 RVA: 0x00008E78 File Offset: 0x00007078
			// (set) Token: 0x060001F7 RID: 503 RVA: 0x0000319E File Offset: 0x0000139E
			public unsafe string _alternateName_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteImageRenderer._updateImage_d__8.NativeFieldInfoPtr__alternateName_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteImageRenderer._updateImage_d__8.NativeFieldInfoPtr__alternateName_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x060001F8 RID: 504 RVA: 0x00008EA0 File Offset: 0x000070A0
			// (set) Token: 0x060001F9 RID: 505 RVA: 0x000031BD File Offset: 0x000013BD
			public TaskAwaiter<Sprite> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteImageRenderer._updateImage_d__8.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Sprite>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Sprite>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteImageRenderer._updateImage_d__8.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Sprite>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000111 RID: 273
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000112 RID: 274
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000113 RID: 275
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000114 RID: 276
			private static readonly IntPtr NativeFieldInfoPtr__alternateName_5__2;

			// Token: 0x04000115 RID: 277
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000116 RID: 278
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000117 RID: 279
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
