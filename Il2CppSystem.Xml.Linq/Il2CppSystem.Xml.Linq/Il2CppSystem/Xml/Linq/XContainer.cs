using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Linq
{
	// Token: 0x02000009 RID: 9
	public class XContainer : XNode
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00003900 File Offset: 0x00001B00
		// Note: this type is marked as 'beforefieldinit'.
		static XContainer()
		{
			Il2CppClassPointerStore<XContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.Linq.dll", "System.Xml.Linq", "XContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XContainer>.NativeClassPtr);
			XContainer.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XContainer>.NativeClassPtr, "content");
			XContainer.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663324);
			XContainer.NativeMethodInfoPtr__ctor_Internal_Void_XContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663325);
			XContainer.NativeMethodInfoPtr_get_LastNode_Public_get_XNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663326);
			XContainer.NativeMethodInfoPtr_Add_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663327);
			XContainer.NativeMethodInfoPtr_Elements_Public_IEnumerable_1_XElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663328);
			XContainer.NativeMethodInfoPtr_Nodes_Public_IEnumerable_1_XNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663329);
			XContainer.NativeMethodInfoPtr_RemoveNodes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663330);
			XContainer.NativeMethodInfoPtr_AddAttribute_Internal_Virtual_New_Void_XAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663331);
			XContainer.NativeMethodInfoPtr_AddAttributeSkipNotify_Internal_Virtual_New_Void_XAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663332);
			XContainer.NativeMethodInfoPtr_AddContentSkipNotify_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663333);
			XContainer.NativeMethodInfoPtr_AddNode_Internal_Void_XNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663334);
			XContainer.NativeMethodInfoPtr_AddNodeSkipNotify_Internal_Void_XNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663335);
			XContainer.NativeMethodInfoPtr_AddString_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663336);
			XContainer.NativeMethodInfoPtr_AddStringSkipNotify_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663337);
			XContainer.NativeMethodInfoPtr_AppendNode_Internal_Void_XNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663338);
			XContainer.NativeMethodInfoPtr_AppendNodeSkipNotify_Internal_Void_XNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663339);
			XContainer.NativeMethodInfoPtr_AppendText_Internal_Virtual_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663340);
			XContainer.NativeMethodInfoPtr_ConvertTextToNode_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663341);
			XContainer.NativeMethodInfoPtr_GetElements_Private_IEnumerable_1_XElement_XName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663342);
			XContainer.NativeMethodInfoPtr_GetStringValue_Internal_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663343);
			XContainer.NativeMethodInfoPtr_ReadContentFrom_Internal_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663344);
			XContainer.NativeMethodInfoPtr_ReadContentFrom_Internal_Void_XmlReader_LoadOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663345);
			XContainer.NativeMethodInfoPtr_RemoveNode_Internal_Void_XNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663346);
			XContainer.NativeMethodInfoPtr_RemoveNodesSkipNotify_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663347);
			XContainer.NativeMethodInfoPtr_ValidateNode_Internal_Virtual_New_Void_XNode_XNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663348);
			XContainer.NativeMethodInfoPtr_ValidateString_Internal_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663349);
			XContainer.NativeMethodInfoPtr_WriteContentTo_Internal_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer>.NativeClassPtr, 100663350);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003B60 File Offset: 0x00001D60
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XContainer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003B9C File Offset: 0x00001D9C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1237208, RefRangeEnd = 1237212, XrefRangeStart = 1237203, XrefRangeEnd = 1237208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XContainer(XContainer other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XContainer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr__ctor_Internal_Void_XContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00003BE8 File Offset: 0x00001DE8
		public unsafe XNode LastNode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1237225, RefRangeEnd = 1237227, XrefRangeStart = 1237212, XrefRangeEnd = 1237225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr_get_LastNode_Public_get_XNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003C28 File Offset: 0x00001E28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1237243, RefRangeEnd = 1237246, XrefRangeStart = 1237227, XrefRangeEnd = 1237243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Object content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr_Add_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003C6C File Offset: 0x00001E6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237253, RefRangeEnd = 1237254, XrefRangeStart = 1237246, XrefRangeEnd = 1237253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<XElement> Elements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr_Elements_Public_IEnumerable_1_XElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<XElement>>(intPtr3) : null;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003CAC File Offset: 0x00001EAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237260, RefRangeEnd = 1237261, XrefRangeStart = 1237254, XrefRangeEnd = 1237260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<XNode> Nodes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr_Nodes_Public_IEnumerable_1_XNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<XNode>>(intPtr3) : null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003CEC File Offset: 0x00001EEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237307, RefRangeEnd = 1237308, XrefRangeStart = 1237261, XrefRangeEnd = 1237307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNodes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr_RemoveNodes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003D20 File Offset: 0x00001F20
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddAttribute(XAttribute a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XContainer.NativeMethodInfoPtr_AddAttribute_Internal_Virtual_New_Void_XAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003D70 File Offset: 0x00001F70
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddAttributeSkipNotify(XAttribute a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XContainer.NativeMethodInfoPtr_AddAttributeSkipNotify_Internal_Virtual_New_Void_XAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003DC0 File Offset: 0x00001FC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237319, RefRangeEnd = 1237320, XrefRangeStart = 1237308, XrefRangeEnd = 1237319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddContentSkipNotify(Object content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr_AddContentSkipNotify_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003E04 File Offset: 0x00002004
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237324, RefRangeEnd = 1237325, XrefRangeStart = 1237320, XrefRangeEnd = 1237324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNode(XNode n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr_AddNode_Internal_Void_XNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003E48 File Offset: 0x00002048
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1237329, RefRangeEnd = 1237332, XrefRangeStart = 1237325, XrefRangeEnd = 1237329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNodeSkipNotify(XNode n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr_AddNodeSkipNotify_Internal_Void_XNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003E8C File Offset: 0x0000208C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237332, XrefRangeEnd = 1237351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddString(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr_AddString_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003ED0 File Offset: 0x000020D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237351, XrefRangeEnd = 1237360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddStringSkipNotify(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr_AddStringSkipNotify_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003F14 File Offset: 0x00002114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237370, RefRangeEnd = 1237371, XrefRangeStart = 1237360, XrefRangeEnd = 1237370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendNode(XNode n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr_AppendNode_Internal_Void_XNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003F58 File Offset: 0x00002158
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1237382, RefRangeEnd = 1237384, XrefRangeStart = 1237371, XrefRangeEnd = 1237382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendNodeSkipNotify(XNode n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr_AppendNodeSkipNotify_Internal_Void_XNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003F9C File Offset: 0x0000219C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237384, XrefRangeEnd = 1237388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AppendText(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XContainer.NativeMethodInfoPtr_AppendText_Internal_Virtual_Void_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003FEC File Offset: 0x000021EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1237399, RefRangeEnd = 1237403, XrefRangeStart = 1237388, XrefRangeEnd = 1237399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConvertTextToNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr_ConvertTextToNode_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004020 File Offset: 0x00002220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237403, XrefRangeEnd = 1237410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<XElement> GetElements(XName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr_GetElements_Private_IEnumerable_1_XElement_XName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<XElement>>(intPtr3) : null;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004070 File Offset: 0x00002270
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1237472, RefRangeEnd = 1237476, XrefRangeStart = 1237410, XrefRangeEnd = 1237472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStringValue(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr_GetStringValue_Internal_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000040AC File Offset: 0x000022AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237476, XrefRangeEnd = 1237482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadContentFrom(XmlReader r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr_ReadContentFrom_Internal_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000040F0 File Offset: 0x000022F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1237495, RefRangeEnd = 1237497, XrefRangeStart = 1237482, XrefRangeEnd = 1237495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadContentFrom(XmlReader r, LoadOptions o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref o;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr_ReadContentFrom_Internal_Void_XmlReader_LoadOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004140 File Offset: 0x00002340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237514, RefRangeEnd = 1237515, XrefRangeStart = 1237497, XrefRangeEnd = 1237514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNode(XNode n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr_RemoveNode_Internal_Void_XNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004184 File Offset: 0x00002384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237515, XrefRangeEnd = 1237522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNodesSkipNotify()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr_RemoveNodesSkipNotify_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000041B8 File Offset: 0x000023B8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ValidateNode(XNode node, XNode previous)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(previous);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XContainer.NativeMethodInfoPtr_ValidateNode_Internal_Virtual_New_Void_XNode_XNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00004218 File Offset: 0x00002418
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ValidateString(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XContainer.NativeMethodInfoPtr_ValidateString_Internal_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004268 File Offset: 0x00002468
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1237527, RefRangeEnd = 1237529, XrefRangeStart = 1237522, XrefRangeEnd = 1237527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteContentTo(XmlWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.NativeMethodInfoPtr_WriteContentTo_Internal_Void_XmlWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002199 File Offset: 0x00000399
		public XContainer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000042AC File Offset: 0x000024AC
		// (set) Token: 0x06000056 RID: 86 RVA: 0x000021A2 File Offset: 0x000003A2
		public unsafe Object content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XContainer_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_get_LastNode_Public_get_XNode_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Object_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_Elements_Public_IEnumerable_1_XElement_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_Nodes_Public_IEnumerable_1_XNode_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNodes_Public_Void_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Internal_Virtual_New_Void_XAttribute_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_AddAttributeSkipNotify_Internal_Virtual_New_Void_XAttribute_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_AddContentSkipNotify_Internal_Void_Object_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_AddNode_Internal_Void_XNode_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_AddNodeSkipNotify_Internal_Void_XNode_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_AddString_Internal_Void_String_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_AddStringSkipNotify_Internal_Void_String_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_AppendNode_Internal_Void_XNode_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_AppendNodeSkipNotify_Internal_Void_XNode_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_AppendText_Internal_Virtual_Void_StringBuilder_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTextToNode_Internal_Void_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_GetElements_Private_IEnumerable_1_XElement_XName_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_GetStringValue_Internal_Static_String_Object_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_ReadContentFrom_Internal_Void_XmlReader_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_ReadContentFrom_Internal_Void_XmlReader_LoadOptions_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNode_Internal_Void_XNode_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNodesSkipNotify_Private_Void_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_ValidateNode_Internal_Virtual_New_Void_XNode_XNode_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_ValidateString_Internal_Virtual_New_Void_String_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_WriteContentTo_Internal_Void_XmlWriter_0;

		// Token: 0x02000020 RID: 32
		public sealed class ContentReader : Object
		{
			// Token: 0x06000172 RID: 370 RVA: 0x00008934 File Offset: 0x00006B34
			// Note: this type is marked as 'beforefieldinit'.
			static ContentReader()
			{
				Il2CppClassPointerStore<XContainer.ContentReader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XContainer>.NativeClassPtr, "ContentReader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XContainer.ContentReader>.NativeClassPtr);
				XContainer.ContentReader.NativeFieldInfoPtr__eCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XContainer.ContentReader>.NativeClassPtr, "_eCache");
				XContainer.ContentReader.NativeFieldInfoPtr__aCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XContainer.ContentReader>.NativeClassPtr, "_aCache");
				XContainer.ContentReader.NativeFieldInfoPtr__lineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XContainer.ContentReader>.NativeClassPtr, "_lineInfo");
				XContainer.ContentReader.NativeFieldInfoPtr__currentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XContainer.ContentReader>.NativeClassPtr, "_currentContainer");
				XContainer.ContentReader.NativeFieldInfoPtr__baseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XContainer.ContentReader>.NativeClassPtr, "_baseUri");
				XContainer.ContentReader.NativeMethodInfoPtr__ctor_Public_Void_XContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer.ContentReader>.NativeClassPtr, 100663351);
				XContainer.ContentReader.NativeMethodInfoPtr__ctor_Public_Void_XContainer_XmlReader_LoadOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer.ContentReader>.NativeClassPtr, 100663352);
				XContainer.ContentReader.NativeMethodInfoPtr_ReadContentFrom_Public_Boolean_XContainer_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer.ContentReader>.NativeClassPtr, 100663353);
				XContainer.ContentReader.NativeMethodInfoPtr_ReadContentFrom_Public_Boolean_XContainer_XmlReader_LoadOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer.ContentReader>.NativeClassPtr, 100663354);
			}

			// Token: 0x06000173 RID: 371 RVA: 0x00008A14 File Offset: 0x00006C14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContentReader(XContainer rootContainer)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XContainer.ContentReader>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootContainer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.ContentReader.NativeMethodInfoPtr__ctor_Public_Void_XContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000174 RID: 372 RVA: 0x00008A60 File Offset: 0x00006C60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237054, XrefRangeEnd = 1237063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContentReader(XContainer rootContainer, XmlReader r, LoadOptions o)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XContainer.ContentReader>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootContainer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(r);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref o;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.ContentReader.NativeMethodInfoPtr__ctor_Public_Void_XContainer_XmlReader_LoadOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000175 RID: 373 RVA: 0x00008ACC File Offset: 0x00006CCC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1237100, RefRangeEnd = 1237101, XrefRangeStart = 1237063, XrefRangeEnd = 1237100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ReadContentFrom(XContainer rootContainer, XmlReader r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootContainer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.ContentReader.NativeMethodInfoPtr_ReadContentFrom_Public_Boolean_XContainer_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000176 RID: 374 RVA: 0x00008B2C File Offset: 0x00006D2C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1237157, RefRangeEnd = 1237158, XrefRangeStart = 1237101, XrefRangeEnd = 1237157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ReadContentFrom(XContainer rootContainer, XmlReader r, LoadOptions o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootContainer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(r);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref o;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer.ContentReader.NativeMethodInfoPtr_ReadContentFrom_Public_Boolean_XContainer_XmlReader_LoadOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000177 RID: 375 RVA: 0x000027AF File Offset: 0x000009AF
			public ContentReader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x06000178 RID: 376 RVA: 0x00008B9C File Offset: 0x00006D9C
			// (set) Token: 0x06000179 RID: 377 RVA: 0x000027B8 File Offset: 0x000009B8
			public NamespaceCache _eCache
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer.ContentReader.NativeFieldInfoPtr__eCache);
					return new NamespaceCache(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NamespaceCache>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer.ContentReader.NativeFieldInfoPtr__eCache), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NamespaceCache>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x0600017A RID: 378 RVA: 0x00008BCC File Offset: 0x00006DCC
			// (set) Token: 0x0600017B RID: 379 RVA: 0x000027E6 File Offset: 0x000009E6
			public NamespaceCache _aCache
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer.ContentReader.NativeFieldInfoPtr__aCache);
					return new NamespaceCache(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NamespaceCache>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer.ContentReader.NativeFieldInfoPtr__aCache), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NamespaceCache>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x0600017C RID: 380 RVA: 0x00008BFC File Offset: 0x00006DFC
			// (set) Token: 0x0600017D RID: 381 RVA: 0x00002814 File Offset: 0x00000A14
			public unsafe IXmlLineInfo _lineInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer.ContentReader.NativeFieldInfoPtr__lineInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlLineInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer.ContentReader.NativeFieldInfoPtr__lineInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x0600017E RID: 382 RVA: 0x00008C2C File Offset: 0x00006E2C
			// (set) Token: 0x0600017F RID: 383 RVA: 0x00002833 File Offset: 0x00000A33
			public unsafe XContainer _currentContainer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer.ContentReader.NativeFieldInfoPtr__currentContainer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer.ContentReader.NativeFieldInfoPtr__currentContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x06000180 RID: 384 RVA: 0x00008C5C File Offset: 0x00006E5C
			// (set) Token: 0x06000181 RID: 385 RVA: 0x00002852 File Offset: 0x00000A52
			public unsafe string _baseUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer.ContentReader.NativeFieldInfoPtr__baseUri);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer.ContentReader.NativeFieldInfoPtr__baseUri), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000113 RID: 275
			private static readonly IntPtr NativeFieldInfoPtr__eCache;

			// Token: 0x04000114 RID: 276
			private static readonly IntPtr NativeFieldInfoPtr__aCache;

			// Token: 0x04000115 RID: 277
			private static readonly IntPtr NativeFieldInfoPtr__lineInfo;

			// Token: 0x04000116 RID: 278
			private static readonly IntPtr NativeFieldInfoPtr__currentContainer;

			// Token: 0x04000117 RID: 279
			private static readonly IntPtr NativeFieldInfoPtr__baseUri;

			// Token: 0x04000118 RID: 280
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XContainer_0;

			// Token: 0x04000119 RID: 281
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XContainer_XmlReader_LoadOptions_0;

			// Token: 0x0400011A RID: 282
			private static readonly IntPtr NativeMethodInfoPtr_ReadContentFrom_Public_Boolean_XContainer_XmlReader_0;

			// Token: 0x0400011B RID: 283
			private static readonly IntPtr NativeMethodInfoPtr_ReadContentFrom_Public_Boolean_XContainer_XmlReader_LoadOptions_0;
		}

		// Token: 0x02000021 RID: 33
		[ObfuscatedName("System.Xml.Linq.XContainer+<Nodes>d__18")]
		public sealed class _Nodes_d__18 : Object
		{
			// Token: 0x06000182 RID: 386 RVA: 0x00008C84 File Offset: 0x00006E84
			// Note: this type is marked as 'beforefieldinit'.
			static _Nodes_d__18()
			{
				Il2CppClassPointerStore<XContainer._Nodes_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XContainer>.NativeClassPtr, "<Nodes>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XContainer._Nodes_d__18>.NativeClassPtr);
				XContainer._Nodes_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XContainer._Nodes_d__18>.NativeClassPtr, "<>1__state");
				XContainer._Nodes_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XContainer._Nodes_d__18>.NativeClassPtr, "<>2__current");
				XContainer._Nodes_d__18.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XContainer._Nodes_d__18>.NativeClassPtr, "<>l__initialThreadId");
				XContainer._Nodes_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XContainer._Nodes_d__18>.NativeClassPtr, "<>4__this");
				XContainer._Nodes_d__18.NativeFieldInfoPtr__n_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XContainer._Nodes_d__18>.NativeClassPtr, "<n>5__2");
				XContainer._Nodes_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer._Nodes_d__18>.NativeClassPtr, 100663355);
				XContainer._Nodes_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer._Nodes_d__18>.NativeClassPtr, 100663356);
				XContainer._Nodes_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer._Nodes_d__18>.NativeClassPtr, 100663357);
				XContainer._Nodes_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Xml_Linq_XNode__get_Current_Private_Virtual_Final_New_get_XNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer._Nodes_d__18>.NativeClassPtr, 100663358);
				XContainer._Nodes_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer._Nodes_d__18>.NativeClassPtr, 100663359);
				XContainer._Nodes_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer._Nodes_d__18>.NativeClassPtr, 100663360);
				XContainer._Nodes_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Xml_Linq_XNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_XNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer._Nodes_d__18>.NativeClassPtr, 100663361);
				XContainer._Nodes_d__18.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer._Nodes_d__18>.NativeClassPtr, 100663362);
			}

			// Token: 0x06000183 RID: 387 RVA: 0x00008DB4 File Offset: 0x00006FB4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Nodes_d__18(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XContainer._Nodes_d__18>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer._Nodes_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000184 RID: 388 RVA: 0x00008DFC File Offset: 0x00006FFC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer._Nodes_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000185 RID: 389 RVA: 0x00008E30 File Offset: 0x00007030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237158, XrefRangeEnd = 1237174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer._Nodes_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x06000186 RID: 390 RVA: 0x00008E6C File Offset: 0x0000706C
			public unsafe XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer._Nodes_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Xml_Linq_XNode__get_Current_Private_Virtual_Final_New_get_XNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XNode>(intPtr3) : null;
				}
			}

			// Token: 0x06000187 RID: 391 RVA: 0x00008EAC File Offset: 0x000070AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237174, XrefRangeEnd = 1237179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer._Nodes_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x06000188 RID: 392 RVA: 0x00008EE0 File Offset: 0x000070E0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer._Nodes_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000189 RID: 393 RVA: 0x00008F20 File Offset: 0x00007120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237179, XrefRangeEnd = 1237181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<XNode> System_Collections_Generic_IEnumerable_System_Xml_Linq_XNode__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer._Nodes_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Xml_Linq_XNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_XNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<XNode>>(intPtr3) : null;
			}

			// Token: 0x0600018A RID: 394 RVA: 0x00008F60 File Offset: 0x00007160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer._Nodes_d__18.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600018B RID: 395 RVA: 0x00002871 File Offset: 0x00000A71
			public _Nodes_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x0600018C RID: 396 RVA: 0x00008FA0 File Offset: 0x000071A0
			// (set) Token: 0x0600018D RID: 397 RVA: 0x0000287A File Offset: 0x00000A7A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._Nodes_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._Nodes_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x0600018E RID: 398 RVA: 0x00008FC8 File Offset: 0x000071C8
			// (set) Token: 0x0600018F RID: 399 RVA: 0x00002895 File Offset: 0x00000A95
			public unsafe XNode __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._Nodes_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._Nodes_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000190 RID: 400 RVA: 0x00008FF8 File Offset: 0x000071F8
			// (set) Token: 0x06000191 RID: 401 RVA: 0x000028B4 File Offset: 0x00000AB4
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._Nodes_d__18.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._Nodes_d__18.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x06000192 RID: 402 RVA: 0x00009020 File Offset: 0x00007220
			// (set) Token: 0x06000193 RID: 403 RVA: 0x000028CF File Offset: 0x00000ACF
			public unsafe XContainer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._Nodes_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._Nodes_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000194 RID: 404 RVA: 0x00009050 File Offset: 0x00007250
			// (set) Token: 0x06000195 RID: 405 RVA: 0x000028EE File Offset: 0x00000AEE
			public unsafe XNode _n_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._Nodes_d__18.NativeFieldInfoPtr__n_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._Nodes_d__18.NativeFieldInfoPtr__n_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400011C RID: 284
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400011D RID: 285
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400011E RID: 286
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400011F RID: 287
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000120 RID: 288
			private static readonly IntPtr NativeFieldInfoPtr__n_5__2;

			// Token: 0x04000121 RID: 289
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000122 RID: 290
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000123 RID: 291
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000124 RID: 292
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Xml_Linq_XNode__get_Current_Private_Virtual_Final_New_get_XNode_0;

			// Token: 0x04000125 RID: 293
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000126 RID: 294
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000127 RID: 295
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Xml_Linq_XNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_XNode_0;

			// Token: 0x04000128 RID: 296
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000022 RID: 34
		[ObfuscatedName("System.Xml.Linq.XContainer+<GetElements>d__39")]
		public sealed class _GetElements_d__39 : Object
		{
			// Token: 0x06000196 RID: 406 RVA: 0x00009080 File Offset: 0x00007280
			// Note: this type is marked as 'beforefieldinit'.
			static _GetElements_d__39()
			{
				Il2CppClassPointerStore<XContainer._GetElements_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XContainer>.NativeClassPtr, "<GetElements>d__39");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XContainer._GetElements_d__39>.NativeClassPtr);
				XContainer._GetElements_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XContainer._GetElements_d__39>.NativeClassPtr, "<>1__state");
				XContainer._GetElements_d__39.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XContainer._GetElements_d__39>.NativeClassPtr, "<>2__current");
				XContainer._GetElements_d__39.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XContainer._GetElements_d__39>.NativeClassPtr, "<>l__initialThreadId");
				XContainer._GetElements_d__39.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XContainer._GetElements_d__39>.NativeClassPtr, "<>4__this");
				XContainer._GetElements_d__39.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XContainer._GetElements_d__39>.NativeClassPtr, "name");
				XContainer._GetElements_d__39.NativeFieldInfoPtr___3__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XContainer._GetElements_d__39>.NativeClassPtr, "<>3__name");
				XContainer._GetElements_d__39.NativeFieldInfoPtr__n_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XContainer._GetElements_d__39>.NativeClassPtr, "<n>5__2");
				XContainer._GetElements_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer._GetElements_d__39>.NativeClassPtr, 100663363);
				XContainer._GetElements_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer._GetElements_d__39>.NativeClassPtr, 100663364);
				XContainer._GetElements_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer._GetElements_d__39>.NativeClassPtr, 100663365);
				XContainer._GetElements_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Xml_Linq_XElement__get_Current_Private_Virtual_Final_New_get_XElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer._GetElements_d__39>.NativeClassPtr, 100663366);
				XContainer._GetElements_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer._GetElements_d__39>.NativeClassPtr, 100663367);
				XContainer._GetElements_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer._GetElements_d__39>.NativeClassPtr, 100663368);
				XContainer._GetElements_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Xml_Linq_XElement__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_XElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer._GetElements_d__39>.NativeClassPtr, 100663369);
				XContainer._GetElements_d__39.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XContainer._GetElements_d__39>.NativeClassPtr, 100663370);
			}

			// Token: 0x06000197 RID: 407 RVA: 0x000091D8 File Offset: 0x000073D8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetElements_d__39(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XContainer._GetElements_d__39>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer._GetElements_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000198 RID: 408 RVA: 0x00009220 File Offset: 0x00007420
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer._GetElements_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000199 RID: 409 RVA: 0x00009254 File Offset: 0x00007454
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237181, XrefRangeEnd = 1237189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer._GetElements_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x0600019A RID: 410 RVA: 0x00009290 File Offset: 0x00007490
			public unsafe XElement System.Collections.Generic.IEnumerator<System.Xml.Linq.XElement>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer._GetElements_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Xml_Linq_XElement__get_Current_Private_Virtual_Final_New_get_XElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XElement>(intPtr3) : null;
				}
			}

			// Token: 0x0600019B RID: 411 RVA: 0x000092D0 File Offset: 0x000074D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237189, XrefRangeEnd = 1237194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer._GetElements_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x0600019C RID: 412 RVA: 0x00009304 File Offset: 0x00007504
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer._GetElements_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600019D RID: 413 RVA: 0x00009344 File Offset: 0x00007544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237194, XrefRangeEnd = 1237203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<XElement> System_Collections_Generic_IEnumerable_System_Xml_Linq_XElement__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer._GetElements_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Xml_Linq_XElement__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_XElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<XElement>>(intPtr3) : null;
			}

			// Token: 0x0600019E RID: 414 RVA: 0x00009384 File Offset: 0x00007584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XContainer._GetElements_d__39.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600019F RID: 415 RVA: 0x0000290D File Offset: 0x00000B0D
			public _GetElements_d__39(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x060001A0 RID: 416 RVA: 0x000093C4 File Offset: 0x000075C4
			// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002916 File Offset: 0x00000B16
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._GetElements_d__39.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._GetElements_d__39.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x060001A2 RID: 418 RVA: 0x000093EC File Offset: 0x000075EC
			// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002931 File Offset: 0x00000B31
			public unsafe XElement __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._GetElements_d__39.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._GetElements_d__39.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x060001A4 RID: 420 RVA: 0x0000941C File Offset: 0x0000761C
			// (set) Token: 0x060001A5 RID: 421 RVA: 0x00002950 File Offset: 0x00000B50
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._GetElements_d__39.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._GetElements_d__39.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x060001A6 RID: 422 RVA: 0x00009444 File Offset: 0x00007644
			// (set) Token: 0x060001A7 RID: 423 RVA: 0x0000296B File Offset: 0x00000B6B
			public unsafe XContainer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._GetElements_d__39.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._GetElements_d__39.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x060001A8 RID: 424 RVA: 0x00009474 File Offset: 0x00007674
			// (set) Token: 0x060001A9 RID: 425 RVA: 0x0000298A File Offset: 0x00000B8A
			public unsafe XName name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._GetElements_d__39.NativeFieldInfoPtr_name);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XName>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._GetElements_d__39.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x060001AA RID: 426 RVA: 0x000094A4 File Offset: 0x000076A4
			// (set) Token: 0x060001AB RID: 427 RVA: 0x000029A9 File Offset: 0x00000BA9
			public unsafe XName __3__name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._GetElements_d__39.NativeFieldInfoPtr___3__name);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XName>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._GetElements_d__39.NativeFieldInfoPtr___3__name), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x060001AC RID: 428 RVA: 0x000094D4 File Offset: 0x000076D4
			// (set) Token: 0x060001AD RID: 429 RVA: 0x000029C8 File Offset: 0x00000BC8
			public unsafe XNode _n_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._GetElements_d__39.NativeFieldInfoPtr__n_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XContainer._GetElements_d__39.NativeFieldInfoPtr__n_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000129 RID: 297
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400012A RID: 298
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400012B RID: 299
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400012C RID: 300
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400012D RID: 301
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x0400012E RID: 302
			private static readonly IntPtr NativeFieldInfoPtr___3__name;

			// Token: 0x0400012F RID: 303
			private static readonly IntPtr NativeFieldInfoPtr__n_5__2;

			// Token: 0x04000130 RID: 304
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000131 RID: 305
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000132 RID: 306
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000133 RID: 307
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Xml_Linq_XElement__get_Current_Private_Virtual_Final_New_get_XElement_0;

			// Token: 0x04000134 RID: 308
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000135 RID: 309
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000136 RID: 310
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Xml_Linq_XElement__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_XElement_0;

			// Token: 0x04000137 RID: 311
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
