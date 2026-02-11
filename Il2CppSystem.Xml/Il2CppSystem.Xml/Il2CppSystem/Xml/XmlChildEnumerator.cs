using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000062 RID: 98
	public sealed class XmlChildEnumerator : Object
	{
		// Token: 0x06000BCD RID: 3021 RVA: 0x000490E0 File Offset: 0x000472E0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlChildEnumerator()
		{
			Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlChildEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr);
			XmlChildEnumerator.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr, "container");
			XmlChildEnumerator.NativeFieldInfoPtr_child = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr, "child");
			XmlChildEnumerator.NativeFieldInfoPtr_isFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr, "isFirst");
			XmlChildEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr, 100665241);
			XmlChildEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr, 100665242);
			XmlChildEnumerator.NativeMethodInfoPtr_MoveNext_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr, 100665243);
			XmlChildEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr, 100665244);
			XmlChildEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr, 100665245);
			XmlChildEnumerator.NativeMethodInfoPtr_get_Current_Internal_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr, 100665246);
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x000491C4 File Offset: 0x000473C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 373622, RefRangeEnd = 373624, XrefRangeStart = 373619, XrefRangeEnd = 373622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlChildEnumerator(XmlNode container)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlChildEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00049210 File Offset: 0x00047410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373624, XrefRangeEnd = 373625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_Collections_IEnumerator_MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlChildEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0004924C File Offset: 0x0004744C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlChildEnumerator.NativeMethodInfoPtr_MoveNext_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00049288 File Offset: 0x00047488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373625, XrefRangeEnd = 373627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlChildEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x000492BC File Offset: 0x000474BC
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlChildEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x000492FC File Offset: 0x000474FC
		public unsafe XmlNode Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlChildEnumerator.NativeMethodInfoPtr_get_Current_Internal_get_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00005EB2 File Offset: 0x000040B2
		public XmlChildEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x0004933C File Offset: 0x0004753C
		// (set) Token: 0x06000BD6 RID: 3030 RVA: 0x00005EBB File Offset: 0x000040BB
		public unsafe XmlNode container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlChildEnumerator.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlChildEnumerator.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x0004936C File Offset: 0x0004756C
		// (set) Token: 0x06000BD8 RID: 3032 RVA: 0x00005EDA File Offset: 0x000040DA
		public unsafe XmlNode child
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlChildEnumerator.NativeFieldInfoPtr_child);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlChildEnumerator.NativeFieldInfoPtr_child), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x0004939C File Offset: 0x0004759C
		// (set) Token: 0x06000BDA RID: 3034 RVA: 0x00005EF9 File Offset: 0x000040F9
		public unsafe bool isFirst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlChildEnumerator.NativeFieldInfoPtr_isFirst);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlChildEnumerator.NativeFieldInfoPtr_isFirst)) = value;
			}
		}

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeFieldInfoPtr_child;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeFieldInfoPtr_isFirst;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlNode_0;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Internal_Boolean_0;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Internal_get_XmlNode_0;
	}
}
