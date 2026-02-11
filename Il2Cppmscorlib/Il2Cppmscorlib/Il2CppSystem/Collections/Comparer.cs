using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004B7 RID: 1207
	[Serializable]
	public sealed class Comparer : Object
	{
		// Token: 0x06004A33 RID: 18995 RVA: 0x001572F8 File Offset: 0x001554F8
		// Note: this type is marked as 'beforefieldinit'.
		static Comparer()
		{
			Il2CppClassPointerStore<Comparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "Comparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Comparer>.NativeClassPtr);
			Comparer.NativeFieldInfoPtr__compareInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Comparer>.NativeClassPtr, "_compareInfo");
			Comparer.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Comparer>.NativeClassPtr, "Default");
			Comparer.NativeFieldInfoPtr_DefaultInvariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Comparer>.NativeClassPtr, "DefaultInvariant");
			Comparer.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer>.NativeClassPtr, 100674085);
			Comparer.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer>.NativeClassPtr, 100674086);
			Comparer.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer>.NativeClassPtr, 100674087);
			Comparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer>.NativeClassPtr, 100674088);
		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x001573B4 File Offset: 0x001555B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414752, XrefRangeEnd = 1414760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Comparer(CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Comparer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x00157400 File Offset: 0x00155600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414760, XrefRangeEnd = 1414783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Comparer(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Comparer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x00157464 File Offset: 0x00155664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414783, XrefRangeEnd = 1414830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x001574C0 File Offset: 0x001556C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1414839, RefRangeEnd = 1414841, XrefRangeStart = 1414830, XrefRangeEnd = 1414839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(Object a, Object b)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A38 RID: 19000 RVA: 0x0001B395 File Offset: 0x00019595
		public Comparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x06004A39 RID: 19001 RVA: 0x00157520 File Offset: 0x00155720
		// (set) Token: 0x06004A3A RID: 19002 RVA: 0x0001B39E File Offset: 0x0001959E
		public unsafe CompareInfo _compareInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Comparer.NativeFieldInfoPtr__compareInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Comparer.NativeFieldInfoPtr__compareInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x06004A3B RID: 19003 RVA: 0x00157550 File Offset: 0x00155750
		// (set) Token: 0x06004A3C RID: 19004 RVA: 0x0001B3BD File Offset: 0x000195BD
		public unsafe static Comparer Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Comparer.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Comparer.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x06004A3D RID: 19005 RVA: 0x00157578 File Offset: 0x00155778
		// (set) Token: 0x06004A3E RID: 19006 RVA: 0x0001B3CF File Offset: 0x000195CF
		public unsafe static Comparer DefaultInvariant
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Comparer.NativeFieldInfoPtr_DefaultInvariant, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Comparer.NativeFieldInfoPtr_DefaultInvariant, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003CD8 RID: 15576
		private static readonly IntPtr NativeFieldInfoPtr__compareInfo;

		// Token: 0x04003CD9 RID: 15577
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04003CDA RID: 15578
		private static readonly IntPtr NativeFieldInfoPtr_DefaultInvariant;

		// Token: 0x04003CDB RID: 15579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0;

		// Token: 0x04003CDC RID: 15580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003CDD RID: 15581
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003CDE RID: 15582
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;
	}
}
