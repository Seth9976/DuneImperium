using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x0200002D RID: 45
	public sealed class AsyncReadManagerRequestMetric : ValueType
	{
		// Token: 0x0600016E RID: 366 RVA: 0x0001A47C File Offset: 0x0001867C
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncReadManagerRequestMetric()
		{
			Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", "AsyncReadManagerRequestMetric");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr);
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<AssetName>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__FileName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<FileName>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__OffsetBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<OffsetBytes>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__SizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<SizeBytes>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetTypeId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<AssetTypeId>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__CurrentBytesRead_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<CurrentBytesRead>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__BatchReadCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<BatchReadCount>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__IsBatchRead_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<IsBatchRead>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<State>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__ReadType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<ReadType>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__PriorityLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<PriorityLevel>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__Subsystem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<Subsystem>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<RequestTimeMicroseconds>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<TimeInQueueMicroseconds>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<TotalTimeMicroseconds>k__BackingField");
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002AF6 File Offset: 0x00000CF6
		public AsyncReadManagerRequestMetric(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002AFF File Offset: 0x00000CFF
		public AsyncReadManagerRequestMetric()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr))
		{
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0001A5D8 File Offset: 0x000187D8
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00002B11 File Offset: 0x00000D11
		public unsafe string _AssetName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0001A600 File Offset: 0x00018800
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002B30 File Offset: 0x00000D30
		public unsafe string _FileName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__FileName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__FileName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0001A628 File Offset: 0x00018828
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00002B4F File Offset: 0x00000D4F
		public unsafe ulong _OffsetBytes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__OffsetBytes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__OffsetBytes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0001A650 File Offset: 0x00018850
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00002B6A File Offset: 0x00000D6A
		public unsafe ulong _SizeBytes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__SizeBytes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__SizeBytes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0001A678 File Offset: 0x00018878
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00002B85 File Offset: 0x00000D85
		public unsafe ulong _AssetTypeId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetTypeId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetTypeId_k__BackingField)) = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0001A6A0 File Offset: 0x000188A0
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002BA0 File Offset: 0x00000DA0
		public unsafe ulong _CurrentBytesRead_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__CurrentBytesRead_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__CurrentBytesRead_k__BackingField)) = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0001A6C8 File Offset: 0x000188C8
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002BBB File Offset: 0x00000DBB
		public unsafe uint _BatchReadCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__BatchReadCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__BatchReadCount_k__BackingField)) = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0001A6F0 File Offset: 0x000188F0
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002BD6 File Offset: 0x00000DD6
		public unsafe bool _IsBatchRead_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__IsBatchRead_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__IsBatchRead_k__BackingField)) = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0001A718 File Offset: 0x00018918
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00002BF1 File Offset: 0x00000DF1
		public unsafe ProcessingState _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0001A740 File Offset: 0x00018940
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00002C0C File Offset: 0x00000E0C
		public unsafe FileReadType _ReadType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__ReadType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__ReadType_k__BackingField)) = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0001A768 File Offset: 0x00018968
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002C27 File Offset: 0x00000E27
		public unsafe Priority _PriorityLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__PriorityLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__PriorityLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0001A790 File Offset: 0x00018990
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00002C42 File Offset: 0x00000E42
		public unsafe AssetLoadingSubsystem _Subsystem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__Subsystem_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__Subsystem_k__BackingField)) = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0001A7B8 File Offset: 0x000189B8
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00002C5D File Offset: 0x00000E5D
		public unsafe double _RequestTimeMicroseconds_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField)) = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0001A7E0 File Offset: 0x000189E0
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00002C78 File Offset: 0x00000E78
		public unsafe double _TimeInQueueMicroseconds_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField)) = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0001A808 File Offset: 0x00018A08
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00002C93 File Offset: 0x00000E93
		public unsafe double _TotalTimeMicroseconds_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField)) = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00002CAE File Offset: 0x00000EAE
		public string AssetName
		{
			get
			{
				return this._AssetName_k__BackingField;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00002CB6 File Offset: 0x00000EB6
		public string FileName
		{
			get
			{
				return this._FileName_k__BackingField;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00002CBE File Offset: 0x00000EBE
		public ulong OffsetBytes
		{
			get
			{
				return this._OffsetBytes_k__BackingField;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00002CC6 File Offset: 0x00000EC6
		public ulong SizeBytes
		{
			get
			{
				return this._SizeBytes_k__BackingField;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00002CCE File Offset: 0x00000ECE
		public ulong AssetTypeId
		{
			get
			{
				return this._AssetTypeId_k__BackingField;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00002CD6 File Offset: 0x00000ED6
		public ulong CurrentBytesRead
		{
			get
			{
				return this._CurrentBytesRead_k__BackingField;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00002CDE File Offset: 0x00000EDE
		public uint BatchReadCount
		{
			get
			{
				return this._BatchReadCount_k__BackingField;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00002CE6 File Offset: 0x00000EE6
		public bool IsBatchRead
		{
			get
			{
				return this._IsBatchRead_k__BackingField;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00002CEE File Offset: 0x00000EEE
		public ProcessingState State
		{
			get
			{
				return this._State_k__BackingField;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00002CF6 File Offset: 0x00000EF6
		public FileReadType ReadType
		{
			get
			{
				return this._ReadType_k__BackingField;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00002CFE File Offset: 0x00000EFE
		public Priority PriorityLevel
		{
			get
			{
				return this._PriorityLevel_k__BackingField;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00002D06 File Offset: 0x00000F06
		public AssetLoadingSubsystem Subsystem
		{
			get
			{
				return this._Subsystem_k__BackingField;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00002D0E File Offset: 0x00000F0E
		public double RequestTimeMicroseconds
		{
			get
			{
				return this._RequestTimeMicroseconds_k__BackingField;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00002D16 File Offset: 0x00000F16
		public double TimeInQueueMicroseconds
		{
			get
			{
				return this._TimeInQueueMicroseconds_k__BackingField;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00002D1E File Offset: 0x00000F1E
		public double TotalTimeMicroseconds
		{
			get
			{
				return this._TotalTimeMicroseconds_k__BackingField;
			}
		}

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr__AssetName_k__BackingField;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeFieldInfoPtr__FileName_k__BackingField;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr__OffsetBytes_k__BackingField;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr__SizeBytes_k__BackingField;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr__AssetTypeId_k__BackingField;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr__CurrentBytesRead_k__BackingField;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr__BatchReadCount_k__BackingField;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeFieldInfoPtr__IsBatchRead_k__BackingField;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr__ReadType_k__BackingField;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr__PriorityLevel_k__BackingField;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr__Subsystem_k__BackingField;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField;
	}
}
