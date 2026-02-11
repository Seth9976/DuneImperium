using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.match.voodoo
{
	// Token: 0x02000247 RID: 583
	public class StackCountData : VersionedDataComponent
	{
		// Token: 0x06001A74 RID: 6772 RVA: 0x00073CC0 File Offset: 0x00071EC0
		// Note: this type is marked as 'beforefieldinit'.
		static StackCountData()
		{
			Il2CppClassPointerStore<StackCountData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.voodoo", "StackCountData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackCountData>.NativeClassPtr);
			StackCountData.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackCountData>.NativeClassPtr, "count");
			StackCountData.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackCountData>.NativeClassPtr, 100667515);
			StackCountData.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackCountData>.NativeClassPtr, 100667516);
			StackCountData.NativeMethodInfoPtr_set_Count_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackCountData>.NativeClassPtr, 100667517);
			StackCountData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackCountData>.NativeClassPtr, 100667518);
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x00073D54 File Offset: 0x00071F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532001, XrefRangeEnd = 532003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackCountData(int initialCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackCountData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackCountData.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x00073D9C File Offset: 0x00071F9C
		// (set) Token: 0x06001A77 RID: 6775 RVA: 0x00073DD8 File Offset: 0x00071FD8
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackCountData.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 515133, RefRangeEnd = 515146, XrefRangeStart = 515133, XrefRangeEnd = 515146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackCountData.NativeMethodInfoPtr_set_Count_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x00073E18 File Offset: 0x00072018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532003, XrefRangeEnd = 532011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackCountData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x0000E768 File Offset: 0x0000C968
		public StackCountData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001A7A RID: 6778 RVA: 0x00073E5C File Offset: 0x0007205C
		// (set) Token: 0x06001A7B RID: 6779 RVA: 0x0000E771 File Offset: 0x0000C971
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackCountData.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackCountData.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeMethodInfoPtr_set_Count_Public_set_Void_Int32_0;

		// Token: 0x04001089 RID: 4233
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
