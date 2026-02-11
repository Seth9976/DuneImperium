using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem
{
	// Token: 0x0200005B RID: 91
	[Serializable]
	public class InvariantComparer : Object
	{
		// Token: 0x06000534 RID: 1332 RVA: 0x00030024 File Offset: 0x0002E224
		// Note: this type is marked as 'beforefieldinit'.
		static InvariantComparer()
		{
			Il2CppClassPointerStore<InvariantComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "InvariantComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvariantComparer>.NativeClassPtr);
			InvariantComparer.NativeFieldInfoPtr_m_compareInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvariantComparer>.NativeClassPtr, "m_compareInfo");
			InvariantComparer.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvariantComparer>.NativeClassPtr, "Default");
			InvariantComparer.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvariantComparer>.NativeClassPtr, 100664203);
			InvariantComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvariantComparer>.NativeClassPtr, 100664204);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x000300A4 File Offset: 0x0002E2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 433996, XrefRangeEnd = 434003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvariantComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvariantComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvariantComparer.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x000300E0 File Offset: 0x0002E2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434003, XrefRangeEnd = 434024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Compare(Object a, Object b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvariantComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00003BC4 File Offset: 0x00001DC4
		public InvariantComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00030140 File Offset: 0x0002E340
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x00003BCD File Offset: 0x00001DCD
		public unsafe CompareInfo m_compareInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvariantComparer.NativeFieldInfoPtr_m_compareInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvariantComparer.NativeFieldInfoPtr_m_compareInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x00030170 File Offset: 0x0002E370
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x00003BEC File Offset: 0x00001DEC
		public unsafe static InvariantComparer Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InvariantComparer.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InvariantComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InvariantComparer.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeFieldInfoPtr_m_compareInfo;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;
	}
}
