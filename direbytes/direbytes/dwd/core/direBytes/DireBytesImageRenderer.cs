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
	// Token: 0x0200000A RID: 10
	public class DireBytesImageRenderer : Subscriber<TextBundleImageData>
	{
		// Token: 0x06000039 RID: 57 RVA: 0x000040FC File Offset: 0x000022FC
		// Note: this type is marked as 'beforefieldinit'.
		static DireBytesImageRenderer()
		{
			Il2CppClassPointerStore<DireBytesImageRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes", "DireBytesImageRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireBytesImageRenderer>.NativeClassPtr);
			DireBytesImageRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesImageRenderer>.NativeClassPtr, "image");
			DireBytesImageRenderer.NativeFieldInfoPtr_imageOverrideType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesImageRenderer>.NativeClassPtr, "imageOverrideType");
			DireBytesImageRenderer.NativeFieldInfoPtr_imageFilePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesImageRenderer>.NativeClassPtr, "imageFilePattern");
			DireBytesImageRenderer.NativeFieldInfoPtr_spriteName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesImageRenderer>.NativeClassPtr, "spriteName");
			DireBytesImageRenderer.NativeFieldInfoPtr_rawImageDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesImageRenderer>.NativeClassPtr, "rawImageDirectory");
			DireBytesImageRenderer.NativeFieldInfoPtr_currentDownloadedImageNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesImageRenderer>.NativeClassPtr, "currentDownloadedImageNames");
			DireBytesImageRenderer.NativeFieldInfoPtr_SPRITENAMEFORMAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesImageRenderer>.NativeClassPtr, "SPRITENAMEFORMAT");
			DireBytesImageRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesImageRenderer>.NativeClassPtr, 100663323);
			DireBytesImageRenderer.NativeMethodInfoPtr_onEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesImageRenderer>.NativeClassPtr, 100663324);
			DireBytesImageRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesImageRenderer>.NativeClassPtr, 100663325);
			DireBytesImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesImageRenderer>.NativeClassPtr, 100663326);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004208 File Offset: 0x00002408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233663, XrefRangeEnd = 1233683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DireBytesImageRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004244 File Offset: 0x00002444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233683, XrefRangeEnd = 1233687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void onEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DireBytesImageRenderer.NativeMethodInfoPtr_onEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004280 File Offset: 0x00002480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233687, XrefRangeEnd = 1233693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DireBytesImageRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000042BC File Offset: 0x000024BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233693, XrefRangeEnd = 1233712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireBytesImageRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireBytesImageRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002208 File Offset: 0x00000408
		public DireBytesImageRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000042F8 File Offset: 0x000024F8
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002211 File Offset: 0x00000411
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00004328 File Offset: 0x00002528
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002230 File Offset: 0x00000430
		public unsafe string imageOverrideType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer.NativeFieldInfoPtr_imageOverrideType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer.NativeFieldInfoPtr_imageOverrideType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00004350 File Offset: 0x00002550
		// (set) Token: 0x06000044 RID: 68 RVA: 0x0000224F File Offset: 0x0000044F
		public unsafe string imageFilePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer.NativeFieldInfoPtr_imageFilePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer.NativeFieldInfoPtr_imageFilePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00004378 File Offset: 0x00002578
		// (set) Token: 0x06000046 RID: 70 RVA: 0x0000226E File Offset: 0x0000046E
		public unsafe string spriteName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer.NativeFieldInfoPtr_spriteName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer.NativeFieldInfoPtr_spriteName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000043A0 File Offset: 0x000025A0
		// (set) Token: 0x06000048 RID: 72 RVA: 0x0000228D File Offset: 0x0000048D
		public unsafe string rawImageDirectory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer.NativeFieldInfoPtr_rawImageDirectory);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer.NativeFieldInfoPtr_rawImageDirectory), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000043C8 File Offset: 0x000025C8
		// (set) Token: 0x0600004A RID: 74 RVA: 0x000022AC File Offset: 0x000004AC
		public unsafe List<string> currentDownloadedImageNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer.NativeFieldInfoPtr_currentDownloadedImageNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer.NativeFieldInfoPtr_currentDownloadedImageNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000043F8 File Offset: 0x000025F8
		// (set) Token: 0x0600004C RID: 76 RVA: 0x000022CB File Offset: 0x000004CB
		public unsafe static string SPRITENAMEFORMAT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DireBytesImageRenderer.NativeFieldInfoPtr_SPRITENAMEFORMAT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DireBytesImageRenderer.NativeFieldInfoPtr_SPRITENAMEFORMAT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_imageOverrideType;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_imageFilePattern;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_spriteName;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_rawImageDirectory;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_currentDownloadedImageNames;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_SPRITENAMEFORMAT;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_onEnable_Protected_Virtual_Void_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200002C RID: 44
		[ObfuscatedName("dwd.core.direBytes.DireBytesImageRenderer+<modelChanged>d__9")]
		public sealed class _modelChanged_d__9 : ValueType
		{
			// Token: 0x060001FA RID: 506 RVA: 0x00008ED0 File Offset: 0x000070D0
			// Note: this type is marked as 'beforefieldinit'.
			static _modelChanged_d__9()
			{
				Il2CppClassPointerStore<DireBytesImageRenderer._modelChanged_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DireBytesImageRenderer>.NativeClassPtr, "<modelChanged>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireBytesImageRenderer._modelChanged_d__9>.NativeClassPtr);
				DireBytesImageRenderer._modelChanged_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesImageRenderer._modelChanged_d__9>.NativeClassPtr, "<>1__state");
				DireBytesImageRenderer._modelChanged_d__9.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesImageRenderer._modelChanged_d__9>.NativeClassPtr, "<>t__builder");
				DireBytesImageRenderer._modelChanged_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesImageRenderer._modelChanged_d__9>.NativeClassPtr, "<>4__this");
				DireBytesImageRenderer._modelChanged_d__9.NativeFieldInfoPtr__imageText_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesImageRenderer._modelChanged_d__9>.NativeClassPtr, "<imageText>5__2");
				DireBytesImageRenderer._modelChanged_d__9.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesImageRenderer._modelChanged_d__9>.NativeClassPtr, "<>u__1");
				DireBytesImageRenderer._modelChanged_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesImageRenderer._modelChanged_d__9>.NativeClassPtr, 100663327);
				DireBytesImageRenderer._modelChanged_d__9.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesImageRenderer._modelChanged_d__9>.NativeClassPtr, 100663328);
			}

			// Token: 0x060001FB RID: 507 RVA: 0x00008F88 File Offset: 0x00007188
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233540, XrefRangeEnd = 1233663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesImageRenderer._modelChanged_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001FC RID: 508 RVA: 0x00008FC0 File Offset: 0x000071C0
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesImageRenderer._modelChanged_d__9.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001FD RID: 509 RVA: 0x000031EB File Offset: 0x000013EB
			public _modelChanged_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060001FE RID: 510 RVA: 0x000031F4 File Offset: 0x000013F4
			public _modelChanged_d__9()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireBytesImageRenderer._modelChanged_d__9>.NativeClassPtr))
			{
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x060001FF RID: 511 RVA: 0x00009008 File Offset: 0x00007208
			// (set) Token: 0x06000200 RID: 512 RVA: 0x00003206 File Offset: 0x00001406
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer._modelChanged_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer._modelChanged_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x06000201 RID: 513 RVA: 0x00009030 File Offset: 0x00007230
			// (set) Token: 0x06000202 RID: 514 RVA: 0x00003221 File Offset: 0x00001421
			public AsyncVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer._modelChanged_d__9.NativeFieldInfoPtr___t__builder);
					return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer._modelChanged_d__9.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x06000203 RID: 515 RVA: 0x00009060 File Offset: 0x00007260
			// (set) Token: 0x06000204 RID: 516 RVA: 0x0000324F File Offset: 0x0000144F
			public unsafe DireBytesImageRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer._modelChanged_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DireBytesImageRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer._modelChanged_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x06000205 RID: 517 RVA: 0x00009090 File Offset: 0x00007290
			// (set) Token: 0x06000206 RID: 518 RVA: 0x0000326E File Offset: 0x0000146E
			public unsafe string _imageText_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer._modelChanged_d__9.NativeFieldInfoPtr__imageText_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer._modelChanged_d__9.NativeFieldInfoPtr__imageText_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x06000207 RID: 519 RVA: 0x000090B8 File Offset: 0x000072B8
			// (set) Token: 0x06000208 RID: 520 RVA: 0x0000328D File Offset: 0x0000148D
			public TaskAwaiter<Sprite> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer._modelChanged_d__9.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Sprite>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Sprite>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesImageRenderer._modelChanged_d__9.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Sprite>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000118 RID: 280
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000119 RID: 281
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400011A RID: 282
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400011B RID: 283
			private static readonly IntPtr NativeFieldInfoPtr__imageText_5__2;

			// Token: 0x0400011C RID: 284
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400011D RID: 285
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400011E RID: 286
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
