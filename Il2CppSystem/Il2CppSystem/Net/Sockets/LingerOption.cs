using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000236 RID: 566
	public class LingerOption : Object
	{
		// Token: 0x0600262F RID: 9775 RVA: 0x000B01B4 File Offset: 0x000AE3B4
		// Note: this type is marked as 'beforefieldinit'.
		static LingerOption()
		{
			Il2CppClassPointerStore<LingerOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "LingerOption");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LingerOption>.NativeClassPtr);
			LingerOption.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LingerOption>.NativeClassPtr, "enabled");
			LingerOption.NativeFieldInfoPtr_lingerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LingerOption>.NativeClassPtr, "lingerTime");
			LingerOption.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LingerOption>.NativeClassPtr, 100669034);
			LingerOption.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LingerOption>.NativeClassPtr, 100669035);
			LingerOption.NativeMethodInfoPtr_set_LingerTime_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LingerOption>.NativeClassPtr, 100669036);
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x000B0248 File Offset: 0x000AE448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489877, XrefRangeEnd = 489878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LingerOption(bool enable, int seconds)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LingerOption>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LingerOption.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C18 RID: 3096
		// (set) Token: 0x06002631 RID: 9777 RVA: 0x000B02A0 File Offset: 0x000AE4A0
		public unsafe bool Enabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LingerOption.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (set) Token: 0x06002632 RID: 9778 RVA: 0x000B02E0 File Offset: 0x000AE4E0
		public unsafe int LingerTime
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LingerOption.NativeMethodInfoPtr_set_LingerTime_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x00010696 File Offset: 0x0000E896
		public LingerOption(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06002634 RID: 9780 RVA: 0x000B0320 File Offset: 0x000AE520
		// (set) Token: 0x06002635 RID: 9781 RVA: 0x0001069F File Offset: 0x0000E89F
		public unsafe bool enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LingerOption.NativeFieldInfoPtr_enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LingerOption.NativeFieldInfoPtr_enabled)) = value;
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06002636 RID: 9782 RVA: 0x000B0348 File Offset: 0x000AE548
		// (set) Token: 0x06002637 RID: 9783 RVA: 0x000106BA File Offset: 0x0000E8BA
		public unsafe int lingerTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LingerOption.NativeFieldInfoPtr_lingerTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LingerOption.NativeFieldInfoPtr_lingerTime)) = value;
			}
		}

		// Token: 0x04001DDD RID: 7645
		private static readonly IntPtr NativeFieldInfoPtr_enabled;

		// Token: 0x04001DDE RID: 7646
		private static readonly IntPtr NativeFieldInfoPtr_lingerTime;

		// Token: 0x04001DDF RID: 7647
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0;

		// Token: 0x04001DE0 RID: 7648
		private static readonly IntPtr NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0;

		// Token: 0x04001DE1 RID: 7649
		private static readonly IntPtr NativeMethodInfoPtr_set_LingerTime_Public_set_Void_Int32_0;
	}
}
