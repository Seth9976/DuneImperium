using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppMono.Btls
{
	// Token: 0x0200002A RID: 42
	public class MonoBtlsBioMono : MonoBtlsBio
	{
		// Token: 0x06000259 RID: 601 RVA: 0x00024038 File Offset: 0x00022238
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsBioMono()
		{
			Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsBioMono");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr);
			MonoBtlsBioMono.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, "handle");
			MonoBtlsBioMono.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, "instance");
			MonoBtlsBioMono.NativeFieldInfoPtr_readFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, "readFunc");
			MonoBtlsBioMono.NativeFieldInfoPtr_writeFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, "writeFunc");
			MonoBtlsBioMono.NativeFieldInfoPtr_controlFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, "controlFunc");
			MonoBtlsBioMono.NativeFieldInfoPtr_readFuncPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, "readFuncPtr");
			MonoBtlsBioMono.NativeFieldInfoPtr_writeFuncPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, "writeFuncPtr");
			MonoBtlsBioMono.NativeFieldInfoPtr_controlFuncPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, "controlFuncPtr");
			MonoBtlsBioMono.NativeFieldInfoPtr_backend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, "backend");
			MonoBtlsBioMono.NativeMethodInfoPtr__ctor_Public_Void_IMonoBtlsBioMono_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, 100663714);
			MonoBtlsBioMono.NativeMethodInfoPtr_mono_btls_bio_mono_new_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, 100663715);
			MonoBtlsBioMono.NativeMethodInfoPtr_mono_btls_bio_mono_initialize_Private_Static_Void_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, 100663716);
			MonoBtlsBioMono.NativeMethodInfoPtr_Control_Private_Int64_ControlCommand_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, 100663717);
			MonoBtlsBioMono.NativeMethodInfoPtr_OnRead_Private_Int32_IntPtr_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, 100663718);
			MonoBtlsBioMono.NativeMethodInfoPtr_OnRead_Private_Static_Int32_IntPtr_IntPtr_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, 100663719);
			MonoBtlsBioMono.NativeMethodInfoPtr_OnWrite_Private_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, 100663720);
			MonoBtlsBioMono.NativeMethodInfoPtr_OnWrite_Private_Static_Int32_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, 100663721);
			MonoBtlsBioMono.NativeMethodInfoPtr_Control_Private_Static_Int64_IntPtr_ControlCommand_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, 100663722);
			MonoBtlsBioMono.NativeMethodInfoPtr_Close_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, 100663723);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000241E4 File Offset: 0x000223E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429455, RefRangeEnd = 429456, XrefRangeStart = 429402, XrefRangeEnd = 429455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsBioMono(IMonoBtlsBioMono backend)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(backend);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBioMono.NativeMethodInfoPtr__ctor_Public_Void_IMonoBtlsBioMono_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00024230 File Offset: 0x00022430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429456, XrefRangeEnd = 429458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_bio_mono_new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBioMono.NativeMethodInfoPtr_mono_btls_bio_mono_new_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00024260 File Offset: 0x00022460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429458, XrefRangeEnd = 429460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_bio_mono_initialize(IntPtr handle, IntPtr instance, IntPtr readFunc, IntPtr writeFunc, IntPtr controlFunc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readFunc;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeFunc;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlFunc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBioMono.NativeMethodInfoPtr_mono_btls_bio_mono_initialize_Private_Static_Void_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000242CC File Offset: 0x000224CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429460, XrefRangeEnd = 429463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long Control(MonoBtlsBioMono.ControlCommand command, long arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref command;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBioMono.NativeMethodInfoPtr_Control_Private_Int64_ControlCommand_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00024324 File Offset: 0x00022524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429463, XrefRangeEnd = 429473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int OnRead(IntPtr data, int dataLength, out int wantMore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &wantMore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBioMono.NativeMethodInfoPtr_OnRead_Private_Int32_IntPtr_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0002438C File Offset: 0x0002258C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429473, XrefRangeEnd = 429491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int OnRead(IntPtr instance, IntPtr data, int dataLength, out int wantMore)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instance;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &wantMore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBioMono.NativeMethodInfoPtr_OnRead_Private_Static_Int32_IntPtr_IntPtr_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000243F4 File Offset: 0x000225F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429491, XrefRangeEnd = 429501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int OnWrite(IntPtr data, int dataLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBioMono.NativeMethodInfoPtr_OnWrite_Private_Int32_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0002444C File Offset: 0x0002264C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429501, XrefRangeEnd = 429519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int OnWrite(IntPtr instance, IntPtr data, int dataLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instance;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBioMono.NativeMethodInfoPtr_OnWrite_Private_Static_Int32_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000244A8 File Offset: 0x000226A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429519, XrefRangeEnd = 429528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Control(IntPtr instance, MonoBtlsBioMono.ControlCommand command, long arg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instance;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref command;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBioMono.NativeMethodInfoPtr_Control_Private_Static_Int64_IntPtr_ControlCommand_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00024504 File Offset: 0x00022704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429528, XrefRangeEnd = 429535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsBioMono.NativeMethodInfoPtr_Close_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002D9E File Offset: 0x00000F9E
		public MonoBtlsBioMono(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00024540 File Offset: 0x00022740
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00002DA7 File Offset: 0x00000FA7
		public new unsafe GCHandle handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsBioMono.NativeFieldInfoPtr_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsBioMono.NativeFieldInfoPtr_handle)) = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00024568 File Offset: 0x00022768
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00002DC2 File Offset: 0x00000FC2
		public unsafe IntPtr instance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsBioMono.NativeFieldInfoPtr_instance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsBioMono.NativeFieldInfoPtr_instance)) = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00024590 File Offset: 0x00022790
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00002DDD File Offset: 0x00000FDD
		public unsafe MonoBtlsBioMono.BioReadFunc readFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsBioMono.NativeFieldInfoPtr_readFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsBioMono.BioReadFunc>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsBioMono.NativeFieldInfoPtr_readFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600026B RID: 619 RVA: 0x000245C0 File Offset: 0x000227C0
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00002DFC File Offset: 0x00000FFC
		public unsafe MonoBtlsBioMono.BioWriteFunc writeFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsBioMono.NativeFieldInfoPtr_writeFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsBioMono.BioWriteFunc>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsBioMono.NativeFieldInfoPtr_writeFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600026D RID: 621 RVA: 0x000245F0 File Offset: 0x000227F0
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00002E1B File Offset: 0x0000101B
		public unsafe MonoBtlsBioMono.BioControlFunc controlFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsBioMono.NativeFieldInfoPtr_controlFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsBioMono.BioControlFunc>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsBioMono.NativeFieldInfoPtr_controlFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00024620 File Offset: 0x00022820
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00002E3A File Offset: 0x0000103A
		public unsafe IntPtr readFuncPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsBioMono.NativeFieldInfoPtr_readFuncPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsBioMono.NativeFieldInfoPtr_readFuncPtr)) = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00024648 File Offset: 0x00022848
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00002E55 File Offset: 0x00001055
		public unsafe IntPtr writeFuncPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsBioMono.NativeFieldInfoPtr_writeFuncPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsBioMono.NativeFieldInfoPtr_writeFuncPtr)) = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00024670 File Offset: 0x00022870
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00002E70 File Offset: 0x00001070
		public unsafe IntPtr controlFuncPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsBioMono.NativeFieldInfoPtr_controlFuncPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsBioMono.NativeFieldInfoPtr_controlFuncPtr)) = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00024698 File Offset: 0x00022898
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00002E8B File Offset: 0x0000108B
		public unsafe IMonoBtlsBioMono backend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsBioMono.NativeFieldInfoPtr_backend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMonoBtlsBioMono>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsBioMono.NativeFieldInfoPtr_backend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeFieldInfoPtr_readFunc;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeFieldInfoPtr_writeFunc;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeFieldInfoPtr_controlFunc;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeFieldInfoPtr_readFuncPtr;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeFieldInfoPtr_writeFuncPtr;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeFieldInfoPtr_controlFuncPtr;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeFieldInfoPtr_backend;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMonoBtlsBioMono_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_bio_mono_new_Private_Static_IntPtr_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_bio_mono_initialize_Private_Static_Void_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_Control_Private_Int64_ControlCommand_Int64_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_OnRead_Private_Int32_IntPtr_Int32_byref_Int32_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_OnRead_Private_Static_Int32_IntPtr_IntPtr_Int32_byref_Int32_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_OnWrite_Private_Int32_IntPtr_Int32_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_OnWrite_Private_Static_Int32_IntPtr_IntPtr_Int32_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_Control_Private_Static_Int64_IntPtr_ControlCommand_Int64_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Virtual_Void_0;

		// Token: 0x020002A7 RID: 679
		public enum ControlCommand
		{
			// Token: 0x040021BF RID: 8639
			Flush = 1
		}

		// Token: 0x020002A8 RID: 680
		public sealed class BioReadFunc : MulticastDelegate
		{
			// Token: 0x06002ACE RID: 10958 RVA: 0x00012FE1 File Offset: 0x000111E1
			// Note: this type is marked as 'beforefieldinit'.
			static BioReadFunc()
			{
				Il2CppClassPointerStore<MonoBtlsBioMono.BioReadFunc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, "BioReadFunc");
				MonoBtlsBioMono.BioReadFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMono.BioReadFunc>.NativeClassPtr, 100663724);
				MonoBtlsBioMono.BioReadFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_IntPtr_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMono.BioReadFunc>.NativeClassPtr, 100663725);
			}

			// Token: 0x06002ACF RID: 10959 RVA: 0x000BF0D0 File Offset: 0x000BD2D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429393, XrefRangeEnd = 429396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BioReadFunc(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsBioMono.BioReadFunc>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBioMono.BioReadFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AD0 RID: 10960 RVA: 0x000BF12C File Offset: 0x000BD32C
			[CallerCount(0)]
			public unsafe int Invoke(IntPtr bio, IntPtr data, int dataLength, out int wantMore)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref bio;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLength;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &wantMore;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBioMono.BioReadFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_IntPtr_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002AD1 RID: 10961 RVA: 0x0001301F File Offset: 0x0001121F
			public BioReadFunc(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040021C0 RID: 8640
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040021C1 RID: 8641
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_IntPtr_Int32_byref_Int32_0;
		}

		// Token: 0x020002A9 RID: 681
		public sealed class BioWriteFunc : MulticastDelegate
		{
			// Token: 0x06002AD2 RID: 10962 RVA: 0x00013028 File Offset: 0x00011228
			// Note: this type is marked as 'beforefieldinit'.
			static BioWriteFunc()
			{
				Il2CppClassPointerStore<MonoBtlsBioMono.BioWriteFunc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, "BioWriteFunc");
				MonoBtlsBioMono.BioWriteFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMono.BioWriteFunc>.NativeClassPtr, 100663726);
				MonoBtlsBioMono.BioWriteFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMono.BioWriteFunc>.NativeClassPtr, 100663727);
			}

			// Token: 0x06002AD3 RID: 10963 RVA: 0x000BF1A0 File Offset: 0x000BD3A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429396, XrefRangeEnd = 429399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BioWriteFunc(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsBioMono.BioWriteFunc>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBioMono.BioWriteFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AD4 RID: 10964 RVA: 0x000BF1FC File Offset: 0x000BD3FC
			[CallerCount(0)]
			public unsafe int Invoke(IntPtr bio, IntPtr data, int dataLength)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref bio;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBioMono.BioWriteFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002AD5 RID: 10965 RVA: 0x00013066 File Offset: 0x00011266
			public BioWriteFunc(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002AD6 RID: 10966 RVA: 0x0001306F File Offset: 0x0001126F
			public static implicit operator MonoBtlsBioMono.BioWriteFunc(Func<IntPtr, IntPtr, int, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<MonoBtlsBioMono.BioWriteFunc>(A_0);
			}

			// Token: 0x06002AD7 RID: 10967 RVA: 0x00013077 File Offset: 0x00011277
			public static MonoBtlsBioMono.BioWriteFunc operator +(MonoBtlsBioMono.BioWriteFunc A_0, MonoBtlsBioMono.BioWriteFunc A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<MonoBtlsBioMono.BioWriteFunc>();
			}

			// Token: 0x06002AD8 RID: 10968 RVA: 0x00013085 File Offset: 0x00011285
			public static MonoBtlsBioMono.BioWriteFunc operator -(MonoBtlsBioMono.BioWriteFunc A_0, MonoBtlsBioMono.BioWriteFunc A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<MonoBtlsBioMono.BioWriteFunc>();
				}
				return delegate2;
			}

			// Token: 0x040021C2 RID: 8642
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040021C3 RID: 8643
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_IntPtr_Int32_0;
		}

		// Token: 0x020002AA RID: 682
		public sealed class BioControlFunc : MulticastDelegate
		{
			// Token: 0x06002AD9 RID: 10969 RVA: 0x00013096 File Offset: 0x00011296
			// Note: this type is marked as 'beforefieldinit'.
			static BioControlFunc()
			{
				Il2CppClassPointerStore<MonoBtlsBioMono.BioControlFunc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsBioMono>.NativeClassPtr, "BioControlFunc");
				MonoBtlsBioMono.BioControlFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMono.BioControlFunc>.NativeClassPtr, 100663728);
				MonoBtlsBioMono.BioControlFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int64_IntPtr_ControlCommand_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMono.BioControlFunc>.NativeClassPtr, 100663729);
			}

			// Token: 0x06002ADA RID: 10970 RVA: 0x000BF264 File Offset: 0x000BD464
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429399, XrefRangeEnd = 429402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BioControlFunc(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsBioMono.BioControlFunc>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBioMono.BioControlFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002ADB RID: 10971 RVA: 0x000BF2C0 File Offset: 0x000BD4C0
			[CallerCount(0)]
			public unsafe long Invoke(IntPtr bio, MonoBtlsBioMono.ControlCommand command, long arg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref bio;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref command;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBioMono.BioControlFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int64_IntPtr_ControlCommand_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002ADC RID: 10972 RVA: 0x000130D4 File Offset: 0x000112D4
			public BioControlFunc(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002ADD RID: 10973 RVA: 0x000130DD File Offset: 0x000112DD
			public static implicit operator MonoBtlsBioMono.BioControlFunc(Func<IntPtr, MonoBtlsBioMono.ControlCommand, long, long> A_0)
			{
				return DelegateSupport.ConvertDelegate<MonoBtlsBioMono.BioControlFunc>(A_0);
			}

			// Token: 0x06002ADE RID: 10974 RVA: 0x000130E5 File Offset: 0x000112E5
			public static MonoBtlsBioMono.BioControlFunc operator +(MonoBtlsBioMono.BioControlFunc A_0, MonoBtlsBioMono.BioControlFunc A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<MonoBtlsBioMono.BioControlFunc>();
			}

			// Token: 0x06002ADF RID: 10975 RVA: 0x000130F3 File Offset: 0x000112F3
			public static MonoBtlsBioMono.BioControlFunc operator -(MonoBtlsBioMono.BioControlFunc A_0, MonoBtlsBioMono.BioControlFunc A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<MonoBtlsBioMono.BioControlFunc>();
				}
				return delegate2;
			}

			// Token: 0x040021C4 RID: 8644
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040021C5 RID: 8645
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int64_IntPtr_ControlCommand_Int64_0;
		}
	}
}
